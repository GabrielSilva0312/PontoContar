using Ponto_Contar.Classes.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Windows.Forms;

namespace Ponto_Contar.Classes.Repository
{
    public class ExportarParaExcelRepository
    {
        public List<ExportarParaExcelViewModel> RetornarDadosParaExportacao(ExportarParaExcelViewModel pDadosExportacao)
        {
            string SQL = "SELECT Nome, dataentrada, datasaidaalmoco, dataentradaalmoco, datasaida, justificativaentrada, justificativasaidaalmoco, " +
                         "justificativasaidaalmoco, justificativaentradaalmoco, justificativasaida, nomemaquina " +
                         "FROM ponto WHERE DataEntrada BETWEEN @DataInicial AND @DataFinal ORDER BY DATAENTRADA";

            var Dados = Ambiente.CN.Query<ExportarParaExcelViewModel>(SQL.ToString(), new { DataInicial = pDadosExportacao.DataInicial, DataFinal = pDadosExportacao.DataFinal }).ToList();

            return Dados;
        }
    }
}