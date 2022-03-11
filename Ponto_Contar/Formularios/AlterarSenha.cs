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
    public partial class AlterarSenha : Form
    {
        public int CodigoRegistro { get; set; }
        public string Nome { get; set; }

        public AlterarSenha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var Dados = new UsuarioRepository().RetornarDadosSenha();

            var Validacao = new List<string>();

            if(txtAlterarSenha.Text != Dados.Senha.ToString())
            {
                MessageBox.Show("Senha Incorreta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAlterarSenha.Text))
                Validacao.Add("Informe a Senha");

            if (string.IsNullOrWhiteSpace(txtAlterarSenha.Text) || string.IsNullOrWhiteSpace(txtNovaAlterarSenha.Text) || string.IsNullOrWhiteSpace(txtConfirmarNovaAlterarSenha.Text))
                Validacao.Add("Informe todas as Senhas");

            if (txtAlterarSenha.Text.Equals(txtNovaAlterarSenha.Text))
                Validacao.Add("A nova Senha deve ser diferente da atual");

            if (!txtNovaAlterarSenha.Text.Equals(txtConfirmarNovaAlterarSenha.Text))
                Validacao.Add("As Senhas não são iguais");

            if (Validacao.Count > 0)
            {
                MessageBox.Show("Verifique os campos:\n\n-> " + string.Join("\n ->", Validacao), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                new UsuarioRepository().AlterarSenhaUsuarioAtual(txtNovaAlterarSenha.Text);
            }
            catch (Exception pEx)
            {
                MessageBox.Show("Falha ao gravar alterações\n\n" + pEx.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MessageBox.Show("Senha Alterada com Sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }
        private void habilitarcampos(bool pedicao)

        {
            txtAlterarSenha.Enabled = pedicao;
            cmdConfirmar.Enabled = pedicao;

            if (pedicao)
                txtAlterarSenha.Focus();
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

        private void AlterarSenha_Load(object sender, EventArgs e)
        {
            CarregarDadosRegistro();
        }

        private void CarregarDadosRegistro()
        {
            var Dados = new UsuarioRepository().RetornarDadosSenha();
        }

        private void txtConfirmarNovaAlterarSenha_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}