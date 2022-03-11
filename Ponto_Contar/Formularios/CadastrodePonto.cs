using Dapper;
using Ponto_Contar.Classes.Repository;
using Ponto_Contar.Classes.ViewModel;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Ponto_Contar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DateTime RetonarHoraServidor()
        {
            string SQL = "SELECT CURRENT_TIMESTAMP AS Hora";
            var Hora = Ambiente.CN.Query<DateTime>(SQL).SingleOrDefault();

            return Hora;
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
            txtSenha_KeyDown(txtSenha, new KeyEventArgs(Keys.Enter));
            LancarConfirmacaoPonto();
        }

        private void habilitarcamposEntrada(bool pedicao)
        {
            txtSenha.Enabled = !pedicao;
            txtNome.Enabled = !pedicao;
            txtJustificativaEntrada.Enabled = pedicao;
            txtJustificativaEntradaAlmoco.Enabled = !pedicao;
            txtJustificativaSaidaAlmoco.Enabled = !pedicao;
            txtJustificativaSaida.Enabled = !pedicao;
            cmdConfirmar.Enabled = pedicao;

            if (pedicao)
                txtSenha.Focus();
        }

        private void habilitarcamposSaidaAlmoco(bool pedicao)
        {
            txtSenha.Enabled = !pedicao;
            txtNome.Enabled = !pedicao;
            txtJustificativaEntrada.Enabled = !pedicao;
            txtJustificativaEntradaAlmoco.Enabled = !pedicao;
            txtJustificativaSaidaAlmoco.Enabled = pedicao;
            txtJustificativaSaida.Enabled = !pedicao;
            DataEntrada.Enabled = !pedicao;
            cmdConfirmar.Enabled = pedicao;

            if (pedicao)
                txtSenha.Focus();
        }

        private void habilitarcamposEntradaAlmoco(bool pedicao)
        {
            txtSenha.Enabled = !pedicao;
            txtNome.Enabled = !pedicao;
            txtJustificativaEntrada.Enabled = !pedicao;
            txtJustificativaEntradaAlmoco.Enabled = pedicao;
            txtJustificativaSaidaAlmoco.Enabled = !pedicao;
            txtJustificativaSaida.Enabled = !pedicao;
            DataEntrada.Enabled = !pedicao;
            DataSaidaAlmoco.Enabled = !pedicao;
            cmdConfirmar.Enabled = pedicao;

            if (pedicao)
                txtSenha.Focus();
        }

        private void habilitarcamposSaida(bool pedicao)
        {
            txtSenha.Enabled = !pedicao;
            txtNome.Enabled = !pedicao;
            txtJustificativaEntrada.Enabled = !pedicao;
            txtJustificativaEntradaAlmoco.Enabled = !pedicao;
            txtJustificativaSaidaAlmoco.Enabled = !pedicao;
            txtJustificativaSaida.Enabled = pedicao;
            DataEntrada.Enabled = !pedicao;
            DataSaidaAlmoco.Enabled = !pedicao;
            DataEntradaAlmoco.Enabled = !pedicao;
            cmdConfirmar.Enabled = pedicao;

            if (pedicao)
                txtSenha.Focus();
        }

        private void habilitarcamposFinal(bool pedicao)
        {
            txtSenha.Enabled = !pedicao;
            txtNome.Enabled = !pedicao;
            txtJustificativaEntrada.Enabled = !pedicao;
            txtJustificativaEntradaAlmoco.Enabled = !pedicao;
            txtJustificativaSaidaAlmoco.Enabled = !pedicao;
            txtJustificativaSaida.Enabled = !pedicao;
            DataEntrada.Enabled = !pedicao;
            DataSaidaAlmoco.Enabled = !pedicao;
            DataEntradaAlmoco.Enabled = !pedicao;
            DataSaida.Enabled = !pedicao;
            cmdConfirmar.Enabled = pedicao;

            if (pedicao)
                txtSenha.Focus();
        }

        private void habilitarcamposRetorno(bool pedicao)
        {
            txtSenha.Enabled = pedicao;
            txtNome.Enabled = !pedicao;
            txtJustificativaEntrada.Enabled = pedicao;
            txtJustificativaEntradaAlmoco.Enabled = !pedicao;
            txtJustificativaSaidaAlmoco.Enabled = !pedicao;
            txtJustificativaSaida.Enabled = !pedicao;
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

            if (e.KeyCode == Keys.F10)
            {
                txtSenha_KeyDown(txtSenha, new KeyEventArgs(Keys.Enter));
            }

            if (e.KeyCode == Keys.F2)
            {
                new CadastrodeColaborador().ShowDialog();
            }

            if (e.KeyCode == Keys.Enter)
            {
                var Date = new PontoViewModel();
                var U = new UsuarioRepository();
                var pSenha = new UsuarioViewModel();
                var Codigo = new UsuarioViewModel();
                var Senha = txtSenha.Text.Trim();
                var Nome = txtNome.Text.Trim();
                var Justificativa = txtJustificativaEntrada.Text.Trim();
                var Data = new DateTime();
                Data = DateTime.Now;

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

                var P = new PontoViewModel();
                P.Nome = txtNome.Text;

                string mensagem = "";

                if (Senha == "")
                    mensagem = mensagem + "Senha.\n";

                if (mensagem != "")
                {
                    MessageBox.Show("Verifique os campos:\n\n" + mensagem);
                    return;
                }

                //txtJustificativaEntrada.Text = "";

                if (U.VerificarSenhaUsuario(Senha) == true)
                {
                    var Pr = new PontoRepository();
                    var Dados = U.VerificarSenhaUsuario(Senha);
                    var DadosPonto = Pr.RetornarSeJaFoiLancado(Senha);

                    if (Dados == false)
                    {
                        habilitarcamposEntrada(true);
                        txtJustificativaEntrada.Focus();

                        return;
                    }

                    if (DadosPonto == null)
                    {
                        var Hora = new PontoViewModel();
                        var HoraRep = new PontoRepository();
                        habilitarcamposEntrada(true);
                        txtJustificativaEntrada.Focus();
                        DateTime HoraAtualServidor = this.RetonarHoraServidor();
                        DataEntrada.Text = HoraAtualServidor.ToString("HH:mm");
                        return;
                    }

                    if (Dados == true && DadosPonto != null && DadosPonto.DataSaidaAlmoco == null)
                    {
                        var p = new PontoRepository();
                        txtJustificativaEntrada.Text = DadosPonto.JustificativaEntrada;
                        DataEntrada.Text = DadosPonto.DataEntrada.ToString("HH:mm");
                        //txtJustificativaEntrada = DadosPonto.JustificativaSaidaAlmoco.Trim(); //TRAZER AS INFORMAÇÕES DA JUSTIFICATIVA
                        habilitarcamposSaidaAlmoco(true);
                        txtJustificativaSaidaAlmoco.Focus();
                        DateTime HoraAtualServidor = this.RetonarHoraServidor();
                        DataSaidaAlmoco.Text = HoraAtualServidor.ToString("HH:mm");
                        return;
                    }

                    if (Dados == true && DadosPonto != null && DadosPonto.DataSaidaAlmoco != null && DadosPonto.DataEntradaAlmoco == null)
                    {
                        var p = new PontoRepository();
                        txtJustificativaEntrada.Text = DadosPonto.JustificativaEntrada;
                        txtJustificativaSaidaAlmoco.Text = DadosPonto.JustificativaSaidaAlmoco;
                        DataEntrada.Text = DadosPonto.DataEntrada.ToString("HH:mm");
                        DataSaidaAlmoco.Text = DadosPonto.DataSaidaAlmoco.Value.ToString("HH:mm");
                        habilitarcamposEntradaAlmoco(true);
                        txtJustificativaEntradaAlmoco.Focus();
                        DateTime HoraAtualServidor = this.RetonarHoraServidor();
                        DataEntradaAlmoco.Text = HoraAtualServidor.ToString("HH:mm");
                        return;
                    }

                    if (Dados == true && DadosPonto != null && DadosPonto.DataSaidaAlmoco != null && DadosPonto.DataEntradaAlmoco != null && DadosPonto.DataSaida == null)
                    {
                        var p = new PontoRepository();
                        txtJustificativaEntrada.Text = DadosPonto.JustificativaEntrada;
                        txtJustificativaSaidaAlmoco.Text = DadosPonto.JustificativaSaidaAlmoco;
                        txtJustificativaEntradaAlmoco.Text = DadosPonto.JustificativaEntradaAlmoco;
                        DataEntrada.Text = DadosPonto.DataEntrada.ToString("HH:mm");
                        DataSaidaAlmoco.Text = DadosPonto.DataSaidaAlmoco.Value.ToString("HH:mm");
                        DataEntradaAlmoco.Text = DadosPonto.DataEntradaAlmoco.Value.ToString("HH:mm");
                        habilitarcamposSaida(true);
                        txtJustificativaSaida.Focus();
                        DateTime HoraAtualServidor = this.RetonarHoraServidor();
                        DataSaida.Text = HoraAtualServidor.ToString("HH:mm");
                        return;
                    }
                    else

                        txtJustificativaEntrada.Text = DadosPonto.JustificativaEntrada;
                    txtJustificativaSaidaAlmoco.Text = DadosPonto.JustificativaSaidaAlmoco;
                    txtJustificativaEntradaAlmoco.Text = DadosPonto.JustificativaEntradaAlmoco;
                    txtJustificativaSaida.Text = DadosPonto.JustificativaSaida;
                    DataEntrada.Text = DadosPonto.DataEntrada.ToString("HH:mm");
                    DataSaidaAlmoco.Text = DadosPonto.DataSaidaAlmoco.Value.ToString("HH:mm");
                    DataEntradaAlmoco.Text = DadosPonto.DataEntradaAlmoco.Value.ToString("HH:mm");
                    DataSaida.Text = DadosPonto.DataSaida.Value.ToString("HH:mm");
                    habilitarcamposFinal(true);
                    MessageBox.Show("Ponto já lançado", "Aviso");
                    txtNome.Clear();
                    txtSenha.Clear();
                    txtJustificativaEntrada.Clear();
                    txtJustificativaSaidaAlmoco.Clear();
                    txtJustificativaEntradaAlmoco.Clear();
                    txtJustificativaSaida.Clear();
                    DataEntrada.Clear();
                    DataEntradaAlmoco.Clear();
                    DataSaidaAlmoco.Clear();
                    DataSaida.Clear();
                    txtSenha.Focus();
                    habilitarcamposRetorno(true);
                    return;
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
                LimparCampos();
                txtSenha.Focus();
            }
            if (e.KeyCode == Keys.F10)
            {
                LancarConfirmacaoPonto();
                MessageBox.Show("Ponto Lançado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                LancarConfirmacaoPonto();
                MessageBox.Show("Ponto Lançado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                Close();
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TesteConexao().ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void txtJustificativaSaidaAlmoco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                LimparCampos();
                txtSenha.Focus();
            }
            if (e.KeyCode == Keys.F10)
            {
                //cmdConfirmar.PerformClick();
                LancarConfirmacaoPonto();
                MessageBox.Show("Ponto Lançado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                //cmdConfirmar.PerformClick();
                LancarConfirmacaoPonto();
                MessageBox.Show("Ponto Lançado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void txtJustificativaEntradaAlmoco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                LimparCampos();
                txtSenha.Focus();
            }
            if (e.KeyCode == Keys.F10)
            {
                //cmdConfirmar.PerformClick();
                LancarConfirmacaoPonto();
                MessageBox.Show("Ponto Lançado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                //cmdConfirmar.PerformClick();
                LancarConfirmacaoPonto();
                MessageBox.Show("Ponto Lançado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void txtJustificativaSaida_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtJustificativaSaida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                LimparCampos();
                txtSenha.Focus();
            }
            if (e.KeyCode == Keys.F10)
            {
                //cmdConfirmar.PerformClick();
                LancarConfirmacaoPonto();
                MessageBox.Show("Ponto Lançado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                //cmdConfirmar.PerformClick();
                LancarConfirmacaoPonto();
                MessageBox.Show("Ponto Lançado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //new Novo_Colaborador().ShowDialog();
            new CadastrodeColaborador().ShowDialog();
        }

        private void LancarConfirmacaoPonto()
        {
            try
            {
                var Justificativa = new PontoViewModel();

                string JustificativaLancada = "";

                if (txtJustificativaEntrada.Enabled == true) JustificativaLancada = txtJustificativaEntrada.Text.Trim();
                if (txtJustificativaEntradaAlmoco.Enabled == true) JustificativaLancada = txtJustificativaEntradaAlmoco.Text.Trim();
                if (txtJustificativaSaida.Enabled == true) JustificativaLancada = txtJustificativaSaida.Text.Trim();
                if (txtJustificativaSaidaAlmoco.Enabled == true) JustificativaLancada = txtJustificativaSaidaAlmoco.Text.Trim();

                var P = new PontoRepository();
                var pCodigo = new UsuarioViewModel();
                var pJustificativa = new UsuarioViewModel();
                pJustificativa.Justificativa = JustificativaLancada;
                var Senha = txtSenha.Text.Trim();

                int tsenha = Int32.Parse(Senha);
                pCodigo.Codigo = tsenha;

                P.LancarPonto(pCodigo, pJustificativa);
            }
            catch (Exception pEx)
            {
                MessageBox.Show("Erro na gravação: " + pEx.Message);
                return;
            }
            MessageBox.Show("Ponto Lançado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
            Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var Frm = new Senha().ShowDialog();
        }
    }
}