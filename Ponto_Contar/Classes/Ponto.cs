using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using Dapper;
using System.Linq;

namespace Ponto_Contar
{
    /*public class Ponto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaidaAlmoco { get; set; }
        public DateTime? DataEntradaAlmoco { get; set; }
        public DateTime? DataSaida { get; set; }
        public string JustificativaEntrada { get; set; }
        public string JustificativaSaidaAlmoco { get; set; }
        public string JustificativaEntradaAlmoco { get; set; }
        public string JustificativaSaida { get; set; }
        public string NomeMaquina { get; set; }
        public string Ip { get; set; }
        public int UsuarioId { get; set; }

        public void LancarPonto(string pSenha, string pJustificativa)
        {
            var U = new Usuario();
            var DadosPonto = RetornarSeJaFoiLancado(pSenha);

            if (DadosPonto == null)

            {
                var dadosUsuario = U.RetornarDadosUsuario(pSenha);

                string SQL = "INSERT INTO Ponto (UsuarioId, DataEntrada, DataSaidaAlmoco, DataEntradaAlmoco, DataSaida, " +
                    "JustificativaEntrada, JustificativaSaidaAlmoco, JustificativaEntradaAlmoco, JustificativaSaida, NomeMaquina, IP)" +
                    " VALUES (@UsuarioId, @DataEntrada, @DataSaidaAlmoco, @DataEntradaAlmoco, @DataSaida, " +
                    "@JustificativaEntrada, @JustificativaSaidaAlmoco, @JustificativaEntradaAlmoco, @JustificativaSaida, @NomeMaquina, @IP)";

                DateTime HoraAtualServidor = this.RetonarHoraServidor();

                var Dadosponto = new Ponto();

                Dadosponto.UsuarioId = dadosUsuario.Id;
                Dadosponto.Nome = Nome;
                Dadosponto.Ip = Util.RetonarIP();
                Dadosponto.NomeMaquina = Util.RetornarNomeMaquina();
                Dadosponto.DataEntrada = RetonarHoraServidor();
                Dadosponto.DataSaidaAlmoco = DataSaidaAlmoco;
                Dadosponto.DataEntradaAlmoco = DataEntradaAlmoco;
                Dadosponto.DataSaida = DataSaida;
                Dadosponto.JustificativaEntrada = pJustificativa;
                Dadosponto.JustificativaSaidaAlmoco = JustificativaSaidaAlmoco;
                Dadosponto.JustificativaEntradaAlmoco = JustificativaEntradaAlmoco;
                Dadosponto.JustificativaSaida = JustificativaSaida;

                Ambiente.CN.Execute(SQL, Dadosponto);
            }

            if (DadosPonto != null && DadosPonto.DataSaidaAlmoco == null)
            {
                var dadosUsuario = U.RetornarDadosUsuario(pSenha);

                string SQL = "UPDATE Ponto SET DataSaidaAlmoco = @DataSaidaAlmoco, JustificativaSaidaAlmoco = @JustificativaSaidaAlmoco " +
                              "WHERE Id = @Id";

                DateTime HoraAtualServidor = this.RetonarHoraServidor();

                Ambiente.CN.Execute(SQL, new { DataSaidaAlmoco = HoraAtualServidor, JustificativaSaidaAlmoco = pJustificativa, Id = DadosPonto.Id });
            }

            if (DadosPonto != null && DadosPonto.DataSaidaAlmoco != null && DadosPonto.DataEntradaAlmoco == null)
            {
                var dadosUsuario = U.RetornarDadosUsuario(pSenha);

                string SQL = "UPDATE Ponto SET DataEntradaAlmoco = @DataEntradaAlmoco, JustificativaEntradaAlmoco = @JustificativaEntradaAlmoco " +
                              "WHERE Id = @Id";

                DateTime HoraAtualServidor = this.RetonarHoraServidor();

                Ambiente.CN.Execute(SQL, new { DataEntradaAlmoco = HoraAtualServidor, JustificativaEntradaAlmoco = pJustificativa, Id = DadosPonto.Id });
            }

            if (DadosPonto != null && DadosPonto.DataSaidaAlmoco != null && DadosPonto.DataEntradaAlmoco != null && DadosPonto.DataSaida == null)
            {
                var dadosUsuario = U.RetornarDadosUsuario(pSenha);

                string SQL = "UPDATE Ponto SET DataSaida = @DataSaida, JustificativaSaida = @JustificativaSaida " +
                              "WHERE Id = @Id";

                DateTime HoraAtualServidor = this.RetonarHoraServidor();

                Ambiente.CN.Execute(SQL, new { DataSaida = HoraAtualServidor, JustificativaSaida = pJustificativa, Id = DadosPonto.Id });
            }
        }

        public Ponto RetornarSeJaFoiLancado(string pSenha)
        {
            var U = new Usuario();
            var dadosUsuario = U.RetornarDadosUsuario(pSenha);

            string SQL = "SELECT * FROM Ponto WHERE UsuarioId = @UsuarioId AND DATE(DataEntrada) = @DataEntrada";

            var data = Ambiente.CN.Query<Ponto>(SQL, new { UsuarioId = dadosUsuario.Id, DataEntrada = DateTime.Now.Date }).SingleOrDefault();

            return data;
        }

        public Ponto(string pNome, string pJustificativa, DateTime pdata)
        {
            Nome = pNome;
        }

        public Ponto()
        {
        }

        public List<Ponto> RelatorioPonto(int pUsuarioId, DateTime pDataInicial, DateTime pDataFinal)
        {
            var U = new Usuario();
            var ListaUsuario = U.RetornarUsuariosNoDisco();

            string SQL = "SELECT * FROM Ponto WHERE UsuarioId =  @UsuarioId AND DATE(DataEntrada) BETWEEN @DataInicial AND @DataFinal";

            var data = Ambiente.CN.Query<Ponto>(SQL, new { UsuarioId = pUsuarioId, DataInicial = pDataInicial, DataFinal = pDataFinal }).ToList();

            return data;
        }

        private DateTime RetonarHoraServidor()
        {
            string machineName = "SERVIDOR";
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.FileName = "net";
            proc.StartInfo.Arguments = @"time \\" + machineName;
            proc.StartInfo.CreateNoWindow = true;

            proc.Start();
            proc.WaitForExit();

            string PrimeiraLinha = "";

            while (!proc.StandardOutput.EndOfStream)
            {
                string currentline = proc.StandardOutput.ReadLine();

                if (!string.IsNullOrEmpty(currentline))
                {
                    PrimeiraLinha = currentline;
                    break;
                }
            }

            string currentTime = PrimeiraLinha.Substring(PrimeiraLinha.Length - 19);

            return DateTime.Parse(currentTime);
        }
    }*/
}