using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Ponto_Contar
{
    internal static class Program
    {
        /*
         * ViewModel - colocar as classes que mapeam a tabela com a classe... UsuarioViewModel   PontoViewModel
         * Repository - Criar UsuarioRepository e PontoRepository que fa´ra o acesso ao banco de dados
         *
         * */

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //if (DateTime.Now.Hour > 8 && Environment.MachineName != "192.168.252.5")
            //return;

            Ambiente.CN = new MySqlConnection();

            //Ambiente.CN.ConnectionString = "Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=PontoContar.accdb;";

            //Ambiente.CN.ConnectionString = @"Provider =Microsoft.Jet.OLEDB.4.0; " +
            //           @"Data source=PontoContar.mdb; Persist Security Info=False";

            try
            {
                MySqlConnectionStringBuilder CSB = new MySqlConnectionStringBuilder();
                CSB.Server = "192.168.254.2";
                CSB.Password = "123123";
                CSB.UserID = "root";
                CSB.Database = "pontocontar";

                string AppName = System.AppDomain.CurrentDomain.FriendlyName.ToLower().Replace("_", "").Replace(".exe", "");
                CSB.Database = AppName;

                Ambiente.CN.ConnectionString = CSB.ToString();

                Ambiente.CN.Open();
            }
            catch (Exception pEx)
            {
                MessageBox.Show("Falha na conexão com o banco de dados.  " + pEx.Message);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}