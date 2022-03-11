using Dapper;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Ponto_Contar
{
   /* public class Usuario
    {
        private object pEx;
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Justificativa { get; set; }
        public bool Ativo { get; set; }

        public Usuario RetornarDadosUsuario(string pSenha)
        {
            string SQL = "SELECT * FROM Usuario where Codigo = '" + pSenha + "'";

            var dados = Ambiente.CN.Query<Usuario>(SQL).SingleOrDefault();

            return dados;
        }

        public Usuario RetornarUsuarioCadastrado(string pNome)
        {
            string SQL = "SELECT * FROM Usuario where Nome = '" + pNome + "'";

            var dados = Ambiente.CN.Query<Usuario>(SQL).SingleOrDefault();

            return dados;
        }

        public Usuario lancarUsuario(string pNome)
        {
            var U = new Usuario();
            var dadosUsuario = U.RetornarUsuarioCadastrado(pNome);

            if (dadosUsuario == null)
            {
                string SQL = "Select Max(Codigo) From Usuario";

                // VARIAVEL PARA RECEBER O VALOR DO BANCO
                int UltimoCodigo = 0;

                // ATRIBUIR A VARIAVEL O RESULTADO DO SELECT
                UltimoCodigo = Ambiente.CN.Query<int>(SQL).SingleOrDefault();

                UltimoCodigo = UltimoCodigo + 1;

                SQL = "INSERT INTO Usuario (Nome, Codigo, Ativo) " +
                    " VALUES (@Nome, @Codigo, @Ativo)";

                var DadosUsuario = new Usuario();

                DadosUsuario.Codigo = UltimoCodigo;
                DadosUsuario.Nome = pNome;
                DadosUsuario.Ativo = true;

                Ambiente.CN.Execute(SQL, DadosUsuario);

                MessageBox.Show("Funcionário Cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return DadosUsuario;
            }
            if (dadosUsuario != null)
            {
                MessageBox.Show("Funcionário já cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return dadosUsuario;
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
    }*/
}