using Dapper;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Ponto_Contar
{
    public class Usuario
    {
        private object pEx;

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public Usuario RetornarDadosUsuario(string pSenha)
        {
            string SQL = "SELECT * FROM Usuario where Codigo = '" + pSenha + "'";

            var dados = Ambiente.CN.Query<Usuario>(SQL).SingleOrDefault();

            return dados;
        }


        public bool VerificarSenhaUsuario(string pSenha)
        {
            string SQL = "SELECT * FROM Usuario where Codigo = '" + pSenha + "'";

            var Dados = Ambiente.CN.Query<Usuario>(SQL).SingleOrDefault();

            //return Dados != null;

            if (Dados == null)
                return false;
            else
                return true;

        }
                
        public List<string> RetornarUsuariosNoDisco()
        {
         
            List<string> Retorno = new List<string>();

            string SQL = "SELECT * FROM Usuario ORDER BY Nome";  

            var Dados = Ambiente.CN.Query<Usuario>(SQL).ToList();

            foreach (var DadosUsuario in Dados)
            {
                string Valor = DadosUsuario.Nome + "  ||  " + DadosUsuario.Codigo;
                Retorno.Add(Valor);
            }

            return Retorno;
        }

    }
}