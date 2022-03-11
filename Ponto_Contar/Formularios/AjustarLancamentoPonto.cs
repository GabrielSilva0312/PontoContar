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
    public partial class AjustarLancamentoPonto : Form
    {
        public int CodigoRegistro { get; set; }
        public string Nome { get; set; }

        public AjustarLancamentoPonto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var DadosBusca = new PontoViewModel()
            {
                Id = CodigoRegistro
            };

            var Id = int.Parse(DadosBusca.Id.ToString());
            var DadosMov = new PontoRepository().RetornarDadosPonto(DadosBusca);
            var DadosUsuario = new UsuarioRepository().RetornarFuncionario(DadosMov.Nome);
            var HoraEntradaCorreta = "";
            var HoraSaidaAlmocoCorreta = "";
            var HoraEntradaAlmocoCorreta = "";
            var HoraSaidaCorreta = "";

            if (txtHoraEntrada.Text.ToString().Trim() == ":" || txtSaida.Text.ToString().Trim() == ":" || txtHoraEntradaAlmoco.Text.ToString().Trim() == ":" || txtSaidaAlmoco.Text.ToString().Trim() == ":")
            {
                MessageBox.Show("Informe todas as Entradas e Saídas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (DadosMov.DataEntradaAlmoco == null)
            {
                DadosMov.DataEntradaAlmoco = DadosMov.DataEntrada;
            }

            if (DadosMov.DataSaidaAlmoco == null)
            {
                DadosMov.DataSaidaAlmoco = DadosMov.DataEntrada;
            }

            if (DadosMov.DataSaida == null)
            {
                DadosMov.DataSaida = DadosMov.DataEntrada;
            }

            if (DadosMov.DataEntrada != null)
            {
                HoraEntradaCorreta = DadosMov.DataEntrada.Date.ToString("dd/MM/yy") + " " + txtHoraEntrada.Text.ToString();
            }

            if (DadosMov.DataSaidaAlmoco != null)
            {
                HoraSaidaAlmocoCorreta = DadosMov.DataSaidaAlmoco.Value.ToString("dd/MM/yy") + " " + txtHoraEntradaAlmoco.Text.ToString();
            }

            if (DadosMov.DataEntradaAlmoco != null)
            {
                HoraEntradaAlmocoCorreta = DadosMov.DataEntradaAlmoco.Value.ToString("dd/MM/yy") + " " + txtSaidaAlmoco.Text.ToString();
            }

            if (DadosMov.DataSaida != null)
            {
                HoraSaidaCorreta = DadosMov.DataSaida.Value.ToString("dd/MM/yy") + " " + txtSaida.Text.ToString();
            }

            var Dados = new PontoViewModel()
            {
                Id = DadosMov.Id
            };

            if (!string.IsNullOrWhiteSpace(HoraEntradaCorreta)) Dados.DataEntrada = Convert.ToDateTime(HoraEntradaCorreta);
            if (!string.IsNullOrWhiteSpace(HoraSaidaAlmocoCorreta)) Dados.DataSaidaAlmoco = Convert.ToDateTime(HoraSaidaAlmocoCorreta);
            if (!string.IsNullOrWhiteSpace(HoraEntradaAlmocoCorreta)) Dados.DataEntradaAlmoco = Convert.ToDateTime(HoraEntradaAlmocoCorreta);
            if (!string.IsNullOrWhiteSpace(HoraSaidaCorreta)) Dados.DataSaida = Convert.ToDateTime(HoraSaidaCorreta);
            
            try
            {
                var Ajuste = new PontoRepository();
                Ajuste.AjustarPonto(Dados);
            }
            catch (Exception pEx)
            {
                MessageBox.Show("Erro na gravação: " + pEx.Message);
                return;
            }
            MessageBox.Show("Ponto Alterado com Sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }
        private void habilitarcampos(bool pedicao)

        {
            txtNome.Enabled = pedicao;
            cmdConfirmar.Enabled = pedicao;

            if (pedicao)
                txtNome.Focus();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                cmdConfirmar.PerformClick();
            }
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

        private void AjustarLancamentoPonto_Load(object sender, EventArgs e)
        {
            var DadosBusca = new PontoViewModel()
            {
                Id = CodigoRegistro
            };

            var Id = int.Parse(DadosBusca.Id.ToString());
            var DadosMov = new PontoRepository().RetornarDadosPonto(DadosBusca);
            var DadosUsuario = new UsuarioRepository().RetornarFuncionario(DadosMov.Nome);

            txtNome.Text = DadosUsuario.Nome;
            txtDataAdmissao.Value = DadosUsuario.DataAdmissao;
            txtFuncao.Text = DadosUsuario.Funcao;
            txtCTPS.Text = DadosUsuario.CTPS;
            chkAtivo.Checked = DadosUsuario.Ativo;

            if (DadosMov.DataEntrada != null)
            {
                txtHoraEntrada.Text = DadosMov.DataEntrada.ToString("HH:mm");
            }

            if (DadosMov.DataEntradaAlmoco != null)
            {
                txtHoraEntradaAlmoco.Text = DadosMov.DataSaidaAlmoco.Value.ToString("HH:mm");
            }

            if (DadosMov.DataSaidaAlmoco != null)
            {
                txtSaidaAlmoco.Text = DadosMov.DataEntradaAlmoco.Value.ToString("HH:mm");
            }

            if (DadosMov.DataSaida != null)
            {
                txtSaida.Text = DadosMov.DataSaida.Value.ToString("HH:mm");
            }
        }

        private void CarregarDadosRegistro()
        {
            if (CodigoRegistro == 0)
                return;

            var Dados = new UsuarioRepository().RetornarDados(CodigoRegistro);

            txtNome.Text = Dados.Nome;
            chkAtivo.Checked = Dados.Ativo;
            txtDataAdmissao.Value = Dados.DataAdmissao;
            txtFuncao.Text = Dados.Funcao;
            txtCTPS.Text = Dados.CTPS;
            txtHoraEntrada.Text = Dados.Entrada;
            txtSaida.Text = Dados.Saida;
            txtHoraEntradaAlmoco.Text = Dados.EntradaAlmoco;
            txtSaidaAlmoco.Text = Dados.SaidaAlmoco;
        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}