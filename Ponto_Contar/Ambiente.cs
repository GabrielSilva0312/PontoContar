using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using Dapper;

namespace Ponto_Contar
{
   public class Ambiente
    {
        public static OleDbConnection CN = new OleDbConnection();
    }
}
