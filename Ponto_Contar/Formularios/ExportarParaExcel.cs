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
using System.IO;

namespace Ponto_Contar
{
    public partial class ExportarParaExcel : Form
    {
        public bool LoginOK { get; set; }
        public int CodigoRegistro { get; set; }
        public string Nome { get; set; }

        public ExportarParaExcel()
        {
            InitializeComponent();
        }

        private void cmdConfirmar_Click_1(object sender, EventArgs e)
        {
            var DataInicialFinal = new ExportarParaExcelViewModel()
            {
                DataInicial = txtDataInicial.Value.Date,
                DataFinal = txtDataFinal.Value.Date
            };

            var DadosExportacao = new ExportarParaExcelRepository().RetornarDadosParaExportacao(DataInicialFinal);

            string NomeArquivo = @"C:\" + "Exportação Ponto " + DateTime.Now.ToString("ddMMyyyy") + ".csv";

            StreamWriter writer = new StreamWriter(NomeArquivo.ToString());

            writer.WriteLine("Nome ;" + "Nome Maquina ;" + "Data Entrada ;" + "Data Saida Alomoco ;" + "Data Entrada Alomoco ;" + "Data Saida ;" + "Justificativa Entrada ;" + "Justificativa Saida Almoco ;" + "Justificativa Entrada Almoco ;" + "Justificativa Saida");

            for (int i = 0; i < DadosExportacao.Count; i++)
            {
                writer.WriteLine(DadosExportacao[i].Nome + ";" + DadosExportacao[i].NomeMaquina + ";" + DadosExportacao[i].DataEntrada + ";" + DadosExportacao[i].DataSaidaAlmoco + ";" + DadosExportacao[i].DataEntradaAlmoco + ";" + DadosExportacao[i].DataSaida + ";" + DadosExportacao[i].JustificativaEntrada + ";" + DadosExportacao[i].JustificativaSaidaAlmoco + ";" + DadosExportacao[i].JustificativaEntradaAlmoco + ";" + DadosExportacao[i].JustificativaSaida);
            }

            writer.Flush();
            writer.Close();

            MessageBox.Show("Arquivo Exportado com Sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Close();
        }

        private void ExportarParaExcel_Load(object sender, EventArgs e)
        {
            CarregarDadosRegistro();
        }

        private void CarregarDadosRegistro()
        {
        }
    }
}