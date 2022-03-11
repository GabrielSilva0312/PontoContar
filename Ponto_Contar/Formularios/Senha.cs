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
    public partial class Senha : Form
    {
        public bool LoginOK { get; set; }
        public int CodigoRegistro { get; set; }
        public string Nome { get; set; }

        public Senha()
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

            if (!txtSenha.Text.Equals(Dados.Senha))
            {
                MessageBox.Show("Senha Incorreta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
                Close();
                LoginOK = true;
                new Relatorio().ShowDialog();
                Close();            
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }
        private void habilitarcampos(bool pedicao)

        {
            txtSenha.Enabled = pedicao;
            cmdConfirmar.Enabled = pedicao;

            if (pedicao)
                txtSenha.Focus();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Cadastro_de_Colaborador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdConfirmar.PerformClick();
            }

            if (e.KeyCode == Keys.F6)
            {
                new AlterarSenha().ShowDialog();
            }
        }

        private void Cadastro_de_Colaborador_Shown(object sender, EventArgs e)
        {
        }

        private void Senha_Load(object sender, EventArgs e)
        {
            CarregarDadosRegistro();
        }

        private void CarregarDadosRegistro()
        {
            var Dados = new UsuarioRepository().RetornarDadosSenha();
        }

        private void txtConfirmarNovaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                cmdConfirmar.PerformClick();
            }
        }
    }
}