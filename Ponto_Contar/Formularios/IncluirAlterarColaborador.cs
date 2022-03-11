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
    public partial class IncluirAlterarColaborador : Form
    {
        public int CodigoRegistro { get; set; }
        public string Nome { get; set; }

        public IncluirAlterarColaborador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var Validacao = new List<string>();

            if (string.IsNullOrWhiteSpace(txtNome.Text))
                Validacao.Add("Entre com o Nome");

            if (Validacao.Count > 0)
            {
                MessageBox.Show("Verifique os campos:\n\n-> " + string.Join("\n ->", Validacao), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var Dados = new UsuarioViewModel()
            {
                Nome = txtNome.Text.Trim(),
                Id = CodigoRegistro,
                Ativo = chkAtivo.Checked,
                DataAdmissao = txtDataAdmissao.Value,
                Funcao = txtFuncao.Text,
                CTPS = txtCTPS.Text,
                Entrada = txtHoraEntrada.Text.Trim(),
                Saida = txtSaida.Text.Trim(),
                EntradaAlmoco = txtHoraEntradaAlmoco.Text.Trim(),
                SaidaAlmoco = txtSaidaAlmoco.Text.Trim()
            };

            try
            {
                new UsuarioRepository().IncluirAlterarUsuario(Dados);
            }
            catch (Exception pEx)
            {
                MessageBox.Show("Falha ao gravar alterações\n\n" + pEx.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

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

        private void IncluirAlterarColaborador_Load(object sender, EventArgs e)
        {
            CarregarDadosRegistro();
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
    }
}