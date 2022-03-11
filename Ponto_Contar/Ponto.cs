using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using Dapper;
using System.Linq;

namespace Ponto_Contar
{
   public class Ponto
    {
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

        public void LancarPonto(string pSenha)
        {
            var U = new Usuario();

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
            Dadosponto.JustificativaEntrada = JustificativaEntrada;
            Dadosponto.JustificativaSaidaAlmoco = JustificativaSaidaAlmoco;
            Dadosponto.JustificativaEntradaAlmoco = JustificativaEntradaAlmoco;
            Dadosponto.JustificativaSaida = JustificativaSaida;



            Ambiente.CN.Execute(SQL, Dadosponto);

            //string SQL = "SELECT Codigo FROM Usuario ORDER BY Nome";

           /* var Pasta = Util.CaminhoBD() + "\\" + Nome.ToUpper();

            if (!Directory.Exists(Pasta))
                Directory.CreateDirectory(Pasta);

            // romulo\romulo_21_08_2017.txt"
            string NomeArquivo = Pasta + "\\" + Nome.ToUpper() + "_" + DateTime.Now.ToString("dd_MM_yyyy") + ".TXT";
            
            StreamWriter SW = new StreamWriter(NomeArquivo);

            DateTime HoraAtualServidor = this.RetonarHoraServidor();

            SW.WriteLine(Util.RetornarNomeMaquina());
            SW.WriteLine(Util.RetonarIP());
            SW.WriteLine(HoraAtualServidor.ToString("HH:mm:ss"));
            
            SW.WriteLine(Nome);*/


        }

        public bool RetornarSeJaFoiLancado(string pSenha)
        {
            var U = new Usuario();
            var dadosUsuario = U.RetornarDadosUsuario(pSenha);

            string SQL = "SELECT Id FROM Ponto WHERE UsuarioId = @UsuarioId AND DataEntrada = @DataEntrada";

            int Id = Ambiente.CN.Query<int>(SQL, new { UsuarioId = U.Id, DataEntrada = DateTime.Now.Date }).SingleOrDefault();

            return Id > 0;           
        }

        public Ponto(string pNome, string pJustificativa, DateTime pdata)
        {
            Nome = pNome;           
            
        }

        public Ponto() { }

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

    }
}

