using System;
using System.Windows.Forms;

namespace Ponto_Contar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            var P = new Ponto()
            {
            Nome = txtNome.Text,
            
           };
                     

            try
            {
                P.LancarPonto(txtSenha.Text);
            }
            catch (Exception pEx)
            {
                MessageBox.Show("Erro na gravação: " + pEx.Message);
            }
             LimparCampos();
            habilitarcampos(false);
            txtSenha.Focus();

            MessageBox.Show("Ponto Lançado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();

        }

        private void habilitarcampos(bool pedicao)
        {
            txtSenha.Enabled = !pedicao;
            txtNome.Enabled = pedicao;
            txtJustificativaEntrada.Enabled = pedicao;
            txtJustificativaEntradaAlmoco.Enabled = pedicao;
            txtJustificativaSaidaAlmoco.Enabled = pedicao;
            txtJustificativaSaida.Enabled = pedicao;
            cmdConfirmar.Enabled = pedicao;

            if (pedicao)
                txtSenha.Focus();

        }
        private void LimparCampos()
        {
            txtSenha.Text = "";
            txtNome.Text = "";
            txtJustificativaEntrada.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Ponto Contar - Versão " + Application.ProductVersion;
            habilitarcampos(false);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                var Senha = txtSenha.Text.Trim();
                var Nome = txtNome.Text.Trim();
                var Justificativa = txtJustificativaEntrada.Text.Trim();
                var Data = new DateTime();
                Data = DateTime.Now;

                var U = new Usuario();

                if (U.VerificarSenhaUsuario(Senha) == false)
                {
                    MessageBox.Show("Usuário não Encontrado", "Aviso");
                    LimparCampos();
                    txtSenha.Focus();
                    return;
                }
                                    
                else
                {
                    var dados = U.RetornarDadosUsuario(Senha);
                    txtNome.Text = dados.Nome;

                }

                var P = new Ponto();
                P.Nome = txtNome.Text;
                               

                if (P.RetornarSeJaFoiLancado(Senha) == true)
                {
                    MessageBox.Show("Ponto já lançado", "Aviso");
                    txtNome.Clear();
                    txtSenha.Clear();
                    txtSenha.Focus();
                    return;
                }

                //txtData.Text = Data.ToString("dd/MM/yyyy HH:mmm:ss");

                string mensagem = "";

                
                if (Senha == "")
                    mensagem = mensagem + "Senha.\n";

                if (mensagem != "")
                {
                    MessageBox.Show("Verifique os campos:\n\n" + mensagem);
                    return;
                }

                txtJustificativaEntrada.Text = "";

                if (U.VerificarSenhaUsuario(Senha) == true)
                {
                    habilitarcampos(true);
                    txtJustificativaEntrada.Focus();

                }
                }

            }

        private void txtJustificativa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJustificativa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                habilitarcampos(false);
                LimparCampos();
                txtSenha.Focus();
            }
            if (e.KeyCode == Keys.F10)
            {
               cmdConfirmar.PerformClick();
                MessageBox.Show("Ponto Lançado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                cmdConfirmar.PerformClick();
                MessageBox.Show("Ponto Lançado.", "Aviso",MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F10 && e.Alt  == true)  
            {
                var historico = new Relatorio();


                historico.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TesteConexao().ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }


          
            
