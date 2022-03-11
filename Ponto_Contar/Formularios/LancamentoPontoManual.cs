using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ponto_Contar.Classes.ViewModel;
using Ponto_Contar.Classes.Repository;

namespace Ponto_Contar
{
    public partial class LancamentoPontoManual : Form
    {
        public int CodigoRegistro { get; set; }
        public string Nome { get; set; }

        public LancamentoPontoManual()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var EntradaManual = "";
            var SaidaManual = "";
            var EntradaAlmocoManual = "";
            var SaidaAlmocoManual = "";
            var FuncionarioId = int.Parse(cmbFuncionarios.SelectedValue.ToString());
            var NomeMaquina = Util.RetornarNomeMaquina();
            var Ip = Util.RetonarIP();

            if (FuncionarioId == 0)
            {
                MessageBox.Show("Selecione o Funcionário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            DateTime Aux;

            if(!DateTime.TryParse(txtHoraEntrada.Text.ToString(), out Aux))
            {
                MessageBox.Show("Informe a Hora da Entrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!DateTime.TryParse(txtHoraSaida.Text.ToString(), out Aux))
            {
                MessageBox.Show("Informe a Hora da Saída.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!DateTime.TryParse(txtHoraEntradaAlmoco.Text.ToString(), out Aux))
            {
                MessageBox.Show("Informe a Hora do Almoço.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!DateTime.TryParse(txtHoraSaidaAlmoco.Text.ToString(), out Aux))
            {
                MessageBox.Show("Informe a Hora do Almoço.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var Dados = new PontoViewModel()
            {
                DataLancamento = Convert.ToDateTime(txtDataLancamento.Text.ToString())
            };

            EntradaManual = Dados.DataLancamento.Date.ToString("dd/MM/yy") + " " + txtHoraEntrada.Text.ToString();
            SaidaManual = Dados.DataLancamento.Date.ToString("dd/MM/yy") + " " + txtHoraSaida.Text.ToString();
            EntradaAlmocoManual = Dados.DataLancamento.Date.ToString("dd/MM/yy") + " " + txtHoraSaidaAlmoco.Text.ToString();
            SaidaAlmocoManual = Dados.DataLancamento.Date.ToString("dd/MM/yy") + " " + txtHoraEntradaAlmoco.Text.ToString();

            var Funcionario = new UsuarioRepository().RetornarDadosFuncionario(FuncionarioId);

            var DadosLancamento = new PontoViewModel()
            {
                DataEntrada = Convert.ToDateTime(EntradaManual),
                DataSaida = Convert.ToDateTime(SaidaManual),
                DataEntradaAlmoco = Convert.ToDateTime(EntradaAlmocoManual),
                DataSaidaAlmoco = Convert.ToDateTime(SaidaAlmocoManual),
                UsuarioId = FuncionarioId,
                Nome = Funcionario.Nome,
                NomeMaquina = NomeMaquina,
                Ip = Ip
            };

            bool RetornarLancamento = new PontoRepository().RetornarLancamento(FuncionarioId, DadosLancamento.DataEntrada);

            if (!RetornarLancamento)
            {
                MessageBox.Show("Já existe lançamento para esse dia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var Ajuste = new PontoRepository();
                Ajuste.LancarPontoManual(DadosLancamento);
            }
            catch (Exception pEx)
            {
                MessageBox.Show("Erro na gravação: " + pEx.Message);
                return;
            }
            MessageBox.Show("Ponto Lançado com Sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void Cadastro_de_Colaborador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdConfirmar.PerformClick();
            }
        }

        private void Cadastro_de_Colaborador_Shown(object sender, EventArgs e)
        {
        }

        private void LancamentoPontoManual_Load(object sender, EventArgs e)
        {
            var DadosFuncionario = new UsuarioViewModel();
            var DadosFuncionarioRep = new UsuarioRepository().RetornarFuncionarioParaCombo(true);

            cmbFuncionarios.DataSource = DadosFuncionarioRep;
            cmbFuncionarios.DisplayMember = "Nome";
            cmbFuncionarios.ValueMember = "Id";
        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}