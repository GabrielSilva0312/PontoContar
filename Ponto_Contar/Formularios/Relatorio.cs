using Ponto_Contar.Classes.Repository;
using Ponto_Contar.Classes.ViewModel;
using Stimulsoft.Report;
using Stimulsoft.Report.Viewer;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Ponto_Contar
{
    public partial class Relatorio : Form
    {
        public bool LoginOK { get; set; }

        private DataTable _DTUsuario = new DataTable();
        private DataTable _DTLancamento = new DataTable();

        public Relatorio()
        {
            InitializeComponent();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            var DadosBusca = new PontoViewModel()
            {
                DataInicial = txtDataInicial.Value.Date,
                DataFinal = txtDataFinal.Value.Date
            };

            var DadosMov = new PontoRepository().RetornarLancamentoPonto(DadosBusca);

            _DTLancamento.Rows.Clear();

            foreach (var Item in DadosMov)
            {
                var Novo = _DTLancamento.NewRow();
                Novo["Id"] = Item.Id;
                Novo["Nome"] = Item.Nome;
                Novo["DataEntrada"] = Item.DataEntrada;
                if (Item.DataSaidaAlmoco != null)
                {
                    Novo["DataSaidaAlmoco"] = Item.DataSaidaAlmoco;
                }
                if (Item.DataEntradaAlmoco != null)
                {
                    Novo["DataEntradaAlmoco"] = Item.DataEntradaAlmoco;
                }
                if (Item.DataSaida != null)
                {
                    Novo["DataSaida"] = Item.DataSaida;
                }
                Novo["JustificativaEntrada"] = Item.JustificativaEntrada;
                Novo["JustificativaSaidaAlmoco"] = Item.JustificativaSaidaAlmoco;
                Novo["JustificativaEntradaAlmoco"] = Item.JustificativaEntradaAlmoco;
                Novo["JustificativaSaida"] = Item.JustificativaSaida;

                _DTLancamento.Rows.Add(Novo);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Buscarusuario()
        {
            var DadosBusca = new UsuarioViewModel();
            var DadosUsuario = new UsuarioRepository();
            var Dados = DadosUsuario.ConsultarUsuarios(DadosBusca);

            _DTUsuario.Rows.Clear();

            foreach (var Item in Dados)
            {
                var Novo = _DTUsuario.NewRow();
                Novo["Nome"] = Item.Nome;

                _DTUsuario.Rows.Add(Novo);
            }
        }

        private void RetornarLancamentoIndividual()
        {
            var DadosBusca = new PontoViewModel()
            {
                Nome = GridUsuarios.SelectedRows[0].Cells["Nome"].Value.ToString(),
                DataInicial = txtDataInicial.Value.Date,
                DataFinal = txtDataFinal.Value.Date
            };

            var DadosMov = new PontoRepository().RetornarLancamentoPontoIndividual(DadosBusca);

            _DTLancamento.Rows.Clear();

            foreach (var Item in DadosMov)
            {
                var Novo = _DTLancamento.NewRow();
                Novo["Id"] = Item.Id;
                Novo["Nome"] = Item.Nome;
                Novo["DataEntrada"] = Item.DataEntrada;
                if (Item.DataSaidaAlmoco != null)
                {
                    Novo["DataSaidaAlmoco"] = Item.DataSaidaAlmoco;
                }
                if (Item.DataEntradaAlmoco != null)
                {
                    Novo["DataEntradaAlmoco"] = Item.DataEntradaAlmoco;
                }
                if (Item.DataSaida != null)
                {
                    Novo["DataSaida"] = Item.DataSaida;
                }
                Novo["JustificativaEntrada"] = Item.JustificativaEntrada;
                Novo["JustificativaSaidaAlmoco"] = Item.JustificativaSaidaAlmoco;
                Novo["JustificativaEntradaAlmoco"] = Item.JustificativaEntradaAlmoco;
                Novo["JustificativaSaida"] = Item.JustificativaSaida;

                _DTLancamento.Rows.Add(Novo);
            }
        }

        private void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            _DTUsuario = new DataTable();

            _DTUsuario.Columns.Add("Nome", Type.GetType("System.String"));

            GridUsuarios.DataSource = _DTUsuario;

            GridUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridUsuarios.RowHeadersVisible = false;
            GridUsuarios.AllowUserToAddRows = false;

            GridUsuarios.ReadOnly = true;
            GridUsuarios.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            _DTLancamento = new DataTable();

            _DTLancamento.Columns.Add("Id", Type.GetType("System.String"));
            _DTLancamento.Columns.Add("Nome", Type.GetType("System.String"));
            _DTLancamento.Columns.Add("DataEntrada", Type.GetType("System.DateTime"));
            _DTLancamento.Columns.Add("DataSaidaAlmoco", Type.GetType("System.DateTime"));
            _DTLancamento.Columns.Add("DataEntradaAlmoco", Type.GetType("System.DateTime"));
            _DTLancamento.Columns.Add("DataSaida", Type.GetType("System.DateTime"));
            _DTLancamento.Columns.Add("JustificativaEntrada", Type.GetType("System.String"));
            _DTLancamento.Columns.Add("JustificativaSaidaAlmoco", Type.GetType("System.String"));
            _DTLancamento.Columns.Add("JustificativaEntradaAlmoco", Type.GetType("System.String"));
            _DTLancamento.Columns.Add("JustificativaSaida", Type.GetType("System.String"));

            GridLancamento.DataSource = _DTLancamento;

            GridLancamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridLancamento.RowHeadersVisible = false;
            GridLancamento.AllowUserToAddRows = false;

            GridLancamento.ReadOnly = true;
            GridLancamento.Columns["Id"].Width = 50;
            GridLancamento.Columns["Nome"].Width = 200;
            GridLancamento.Columns["DataEntrada"].Width = 200;
            GridLancamento.Columns["DataSaidaAlmoco"].Width = 200;
            GridLancamento.Columns["DataEntradaAlmoco"].Width = 200;
            GridLancamento.Columns["DataSaida"].Width = 200;
            GridLancamento.Columns["JustificativaEntrada"].Width = 200;
            GridLancamento.Columns["JustificativaSaidaAlmoco"].Width = 200;
            GridLancamento.Columns["JustificativaEntradaAlmoco"].Width = 200;
            GridLancamento.Columns["JustificativaSaida"].Width = 200;

            GridLancamento.ReadOnly = true;

            GridLancamento.Columns["DataEntrada"].HeaderText = "Data Entrada";
            GridLancamento.Columns["DataSaidaAlmoco"].HeaderText = "Data Saída Almoco";
            GridLancamento.Columns["DataEntradaAlmoco"].HeaderText = "Data Entrada Almoco";
            GridLancamento.Columns["DataSaida"].HeaderText = "Data Saída";
            GridLancamento.Columns["JustificativaEntrada"].HeaderText = "Justificativa Entrada";
            GridLancamento.Columns["JustificativaSaidaAlmoco"].HeaderText = "Justificativa Saída Almoco";
            GridLancamento.Columns["JustificativaEntradaAlmoco"].HeaderText = "Justificativa Entrada Almoco";
            GridLancamento.Columns["JustificativaSaida"].HeaderText = "Justificativa Saída";

            Buscarusuario();
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscarusuario();
            }
        }

        private void GridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void GridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RetornarLancamentoIndividual();
        }

        private void cmdRelatorio_Click(object sender, EventArgs e)
        {
            var Usuario = new UsuarioViewModel();
            string BuscaUsuario = Usuario.Nome;

            var DadosPonto = new PontoRepository().RetornarLancamentoPontoRelatorio(txtDataFinal.Value.Year, txtDataFinal.Value.Month);

            StiReport Relat = new StiReport();

            if (File.Exists("EmissaoPonto.mrt"))
                Relat.Load("EmissaoPonto.mrt");

            Relat.RegBusinessObject("Dados", DadosPonto);

            Relat.Dictionary.Synchronize();

            Relat.PreviewSettings = (Relat.PreviewSettings & (int)(~StiPreviewSettings.Bookmarks));
            Relat.PreviewSettings = (Relat.PreviewSettings & (int)(~StiPreviewSettings.SendEMail));

            Relat.GlobalizationManager.Culture = new System.Globalization.CultureInfo("pt-BR");

            //Relat.Design();
            Relat.Show();
        }

        private void cmdAjustarLancamento_Click(object sender, EventArgs e)
        {
            var DadosBusca = new PontoViewModel()
            {
                Id = int.Parse(GridLancamento.SelectedRows[0].Cells["Id"].Value.ToString())
            };

            var DadosMov = new PontoRepository().RetornarDadosPonto(DadosBusca);

            var Frm = new AjustarLancamentoPonto();
            Frm.CodigoRegistro = DadosMov.Id;
            Frm.ShowDialog();
        }

        private void cmdLancamentoManual_Click(object sender, EventArgs e)
        {
            var Frm = new LancamentoPontoManual();
            Frm.ShowDialog();
        }

        private void cmdExportarParaExcel_Click(object sender, EventArgs e)
        {
            var Frm = new ExportarParaExcel();
            Frm.ShowDialog();
        }
    }
}