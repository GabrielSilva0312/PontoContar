using Dapper;
using Ponto_Contar.Classes.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto_Contar.Classes.Repository
{
    public class PontoRepository
    {
        public void LancarPonto(UsuarioViewModel pSenha, UsuarioViewModel pJustificativa)
        {
            var UsuarioView = new UsuarioViewModel();
            var U = new UsuarioRepository();
            var DadosUsuario = U.RetornarDadosUsuario(pSenha.Codigo.ToString());
            var P = new PontoRepository();
            var DadosPonto = P.RetornarSeJaFoiLancado(pSenha.Codigo.ToString());

            if (DadosPonto == null)

            {
                var dadosUsuario = U.RetornarDadosUsuario(pSenha.Codigo.ToString());

                string SQL = "INSERT INTO Ponto (Nome, UsuarioId, DataEntrada, DataSaidaAlmoco, DataEntradaAlmoco, DataSaida, " +
                    " JustificativaEntrada, JustificativaSaidaAlmoco, JustificativaEntradaAlmoco, JustificativaSaida, NomeMaquina, IP)" +
                    " VALUES (@Nome, @UsuarioId, CURRENT_TIMESTAMP, @DataSaidaAlmoco, @DataEntradaAlmoco, @DataSaida, " +
                    " @JustificativaEntrada, @JustificativaSaidaAlmoco, @JustificativaEntradaAlmoco, @JustificativaSaida, @NomeMaquina, @IP)";

                var Dadosponto = new PontoViewModel();

                Dadosponto.UsuarioId = dadosUsuario.Id;
                Dadosponto.Nome = dadosUsuario.Nome;
                Dadosponto.Ip = Util.RetonarIP();
                Dadosponto.NomeMaquina = Util.RetornarNomeMaquina();
                Dadosponto.DataEntrada = RetonarHoraServidor();
                Dadosponto.DataSaidaAlmoco = Dadosponto.DataSaidaAlmoco;
                Dadosponto.DataEntradaAlmoco = Dadosponto.DataEntradaAlmoco;
                Dadosponto.DataSaida = Dadosponto.DataSaida;
                Dadosponto.JustificativaEntrada = pJustificativa.Justificativa;
                Dadosponto.JustificativaEntradaAlmoco = Dadosponto.JustificativaSaidaAlmoco;
                Dadosponto.JustificativaEntradaAlmoco = Dadosponto.JustificativaEntradaAlmoco;
                Dadosponto.JustificativaSaida = Dadosponto.JustificativaSaida;

                DateTime HoraAtualServidor = this.RetonarHoraServidor();

                Ambiente.CN.Execute(SQL, Dadosponto);
            }

            if (DadosPonto != null && DadosPonto.DataSaidaAlmoco == null)
            {
                var dadosUsuario = U.RetornarDadosUsuario(pSenha.Codigo.ToString());

                string SQL = "UPDATE Ponto SET DataSaidaAlmoco = CURRENT_TIMESTAMP, JustificativaSaidaAlmoco = @JustificativaSaidaAlmoco " +
                              "WHERE Id = @Id";

                DateTime HoraAtualServidor = this.RetonarHoraServidor();

                Ambiente.CN.Execute(SQL, new { DataSaidaAlmoco = HoraAtualServidor, JustificativaSaidaAlmoco = pJustificativa.Justificativa, Id = DadosPonto.Id });
            }

            if (DadosPonto != null && DadosPonto.DataSaidaAlmoco != null && DadosPonto.DataEntradaAlmoco == null)
            {
                var dadosUsuario = U.RetornarDadosUsuario(pSenha.Codigo.ToString());

                string SQL = "UPDATE Ponto SET DataEntradaAlmoco = CURRENT_TIMESTAMP, JustificativaEntradaAlmoco = @JustificativaEntradaAlmoco " +
                              "WHERE Id = @Id";

                DateTime HoraAtualServidor = this.RetonarHoraServidor();

                Ambiente.CN.Execute(SQL, new { DataEntradaAlmoco = HoraAtualServidor, JustificativaEntradaAlmoco = pJustificativa.Justificativa, Id = DadosPonto.Id });
            }

            if (DadosPonto != null && DadosPonto.DataSaidaAlmoco != null && DadosPonto.DataEntradaAlmoco != null && DadosPonto.DataSaida == null)
            {
                var dadosUsuario = U.RetornarDadosUsuario(pSenha.Codigo.ToString());

                string SQL = "UPDATE Ponto SET DataSaida = CURRENT_TIMESTAMP, JustificativaSaida = @JustificativaSaida " +
                              "WHERE Id = @Id";

                DateTime HoraAtualServidor = this.RetonarHoraServidor();

                Ambiente.CN.Execute(SQL, new { DataSaida = HoraAtualServidor, JustificativaSaida = pJustificativa.Justificativa, Id = DadosPonto.Id });
            }
        }

        public PontoViewModel RetornarSeJaFoiLancado(string Codigo)
        {
            var Usuario = new UsuarioViewModel();
            var U = new UsuarioRepository();
            var dadosUsuario = U.RetornarDadosUsuario(Codigo);

            string SQL = "SELECT * FROM Ponto WHERE UsuarioId = " + dadosUsuario.Codigo + " AND DATE(DataEntrada) = @DataEntrada";

            var data = Ambiente.CN.Query<PontoViewModel>(SQL, new { UsuarioId = dadosUsuario.Id, DataEntrada = DateTime.Now.Date }).SingleOrDefault();

            return data;
        }

        public bool RetornarLancamento(int FuncionarioId, DateTime DataLancamento)
        {
            /*var Usuario = new UsuarioViewModel();
            var U = new UsuarioRepository();
            var dadosUsuario = U.RetornarDadosUsuario(Id);*/

            string SQL = "SELECT * FROM Ponto WHERE UsuarioId = " + FuncionarioId + " AND DATE(DataEntrada) = @DataEntrada";

            var data = Ambiente.CN.Query<PontoViewModel>(SQL, new { UsuarioId = FuncionarioId, DataEntrada = DataLancamento.Date }).SingleOrDefault();

            if (data == null)
                return true;
            else
                return false;
        }

        public void AjustarPonto(PontoViewModel pDados)
        {
            string SQL = "UPDATE Ponto SET DataEntrada = @DataEntrada, DataSaidaAlmoco = @DataSaidaAlmoco, DataEntradaAlmoco = @DataEntradaAlmoco, DataSaida = @DataSaida " +
                              "WHERE Id = @Id";

            Ambiente.CN.Execute(SQL, new { DataEntrada = pDados.DataEntrada, DataEntradaAlmoco = pDados.DataEntradaAlmoco, DataSaidaAlmoco = pDados.DataSaidaAlmoco, DataSaida = pDados.DataSaida, Id = pDados.Id });
        }

        public void LancarPontoManual(PontoViewModel pDados)
        {
            string SQL = "INSERT INTO Ponto (Nome, UsuarioId, DataEntrada, DataSaidaAlmoco, DataEntradaAlmoco, DataSaida, " +
                    " JustificativaEntrada, JustificativaSaidaAlmoco, JustificativaEntradaAlmoco, JustificativaSaida, NomeMaquina, IP)" +
                    " VALUES (@Nome, @UsuarioId, @DataEntrada, @DataSaidaAlmoco, @DataEntradaAlmoco, @DataSaida, " +
                    " @JustificativaEntrada, @JustificativaSaidaAlmoco, @JustificativaEntradaAlmoco, @JustificativaSaida, @NomeMaquina, @IP)";

            Ambiente.CN.Execute(SQL, pDados);
        }

        public PontoViewModel Ponto(PontoViewModel pNome, PontoViewModel pJustificativa, PontoViewModel pdata)
        {
            var Nome = new PontoViewModel();
            Nome = pNome;
            return pNome;
        }

        private DateTime RetonarHoraServidor()
        {
            string SQL = "SELECT CURRENT_TIMESTAMP AS Hora";
            var Hora = Ambiente.CN.Query<DateTime>(SQL).SingleOrDefault();

            return Hora;
        }

        public List<PontoViewModel> RetornarLancamentoPontoIndividual(PontoViewModel pDados)
        {
            var SQL = "SELECT * FROM Ponto WHERE Nome = @Nome AND DATE(DataEntrada) BETWEEN @DataInicial AND @DataFinal";

            var Data = Ambiente.CN.Query<PontoViewModel>(SQL, new { Nome = pDados.Nome, DataInicial = pDados.DataInicial.Date, DataFinal = pDados.DataFinal.Date }).ToList();

            return Data;
        }

        public PontoViewModel RetornarDadosPonto(PontoViewModel pDados)
        {
            var SQL = "SELECT * FROM Ponto WHERE Id = @Id";

            var Data = Ambiente.CN.Query<PontoViewModel>(SQL, new { Id = pDados.Id }).SingleOrDefault();

            return Data;
        }

        public List<PontoViewModel> RetornarLancamentoPonto(PontoViewModel pDados)
        {
            var SQL = "SELECT * FROM Ponto WHERE DATE(DataEntrada) BETWEEN @DataInicial AND @DataFinal";

            var Data = Ambiente.CN.Query<PontoViewModel>(SQL, new { DataInicial = pDados.DataInicial.Date, DataFinal = pDados.DataFinal.Date }).ToList();

            return Data;
        }

        public List<PontoImpressaoViewModel> RetornarLancamentoPontoRelatorio(int pAno, int pMes)
        {
            var SQL = "SELECT * FROM Ponto P INNER JOIN Usuario U ON U.Id = P.UsuarioId WHERE YEAR(P.DataEntrada) = @Ano AND MONTH(P.DataEntrada) = @Mes " +
                " ORDER BY P.UsuarioId, P.DataEntrada";

            var Retorno = new List<PontoImpressaoViewModel>();

            int DiasMes = DateTime.DaysInMonth(pAno, pMes);

            var Data = Ambiente.CN.Query<PontoImpressaoViewModel>(SQL, new { Ano = pAno, Mes = pMes }).ToList();

            var ListaUsuarios = Data.Select(d => d.UsuarioId).Distinct().ToList();

            var PrimeiroDiaMes = new DateTime(pAno, pMes, 1);
            var UltimoDiaMes = PrimeiroDiaMes.AddMonths(1).AddDays(-1);

            foreach (var IdUsuario in ListaUsuarios)
            {
                var ListaPonto = Data.Where(d => d.UsuarioId == IdUsuario).ToList();
                var DadosUsuarioPonto = new UsuarioRepository().RetornarDadosFuncionario(IdUsuario);

                for (int I = 1; I <= DiasMes; I++)
                {
                    var DadosDiaPontoLancado = ListaPonto.Where(d => d.DataEntrada.Day == I).SingleOrDefault();
                    if (DadosDiaPontoLancado == null)
                        DadosDiaPontoLancado = new ViewModel.PontoImpressaoViewModel()
                        {
                            DataEntrada = new DateTime(pAno, pMes, I),
                            UsuarioId = IdUsuario,
                            Codigo = DadosUsuarioPonto.Codigo.ToString(),
                            Nome = DadosUsuarioPonto.Nome,
                            Funcao = DadosUsuarioPonto.Funcao,
                            DataAdmissao = DadosUsuarioPonto.DataAdmissao,
                            CTPS = DadosUsuarioPonto.CTPS,
                            Entrada = DadosUsuarioPonto.Entrada,
                            Saida = DadosUsuarioPonto.Saida,
                            EntradaAlmoco = DadosUsuarioPonto.EntradaAlmoco,
                            SaidaAlmoco = DadosUsuarioPonto.SaidaAlmoco
                        };

                    DadosDiaPontoLancado.DataInicial = PrimeiroDiaMes;
                    DadosDiaPontoLancado.DataFinal = UltimoDiaMes;

                    Retorno.Add(DadosDiaPontoLancado);
                }
            }
            return Retorno;
        }
    }
}