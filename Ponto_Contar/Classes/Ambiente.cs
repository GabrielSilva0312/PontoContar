using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using Dapper;
using MySql.Data.MySqlClient;

namespace Ponto_Contar
{
   public class Ambiente
    {
        public static MySqlConnection CN = new MySqlConnection();
    }
}
