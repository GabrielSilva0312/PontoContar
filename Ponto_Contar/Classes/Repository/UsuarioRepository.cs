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
    public class UsuarioRepository
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Ativo { get; set; }

        public int ObterProximo(string pCampo, string pTabela)
        {
            string SQL = "SELECT IFNULL(MAX(" + pCampo + "), 1) + 1 FROM " + pTabela;

            var data = Ambiente.CN.Query<int>(SQL, null).SingleOrDefault();

            return data;
        }

        public int ObterProximoCodigo(string pCampo, string pTabela)
        {
            string SQL = "SELECT IFNULL(MAX(" + pCampo + "), 1) + 1 FROM " + pTabela;

            var data = Ambiente.CN.Query<int>(SQL, null).SingleOrDefault();

            return data;
        }

        public UsuarioViewModel RetornarDadosFuncionario(int pId)
        {
            string SQL = "SELECT * FROM Usuario where Id = " + pId;

            var Dados = Ambiente.CN.Query<UsuarioViewModel>(SQL).SingleOrDefault();

            return Dados;
        }

        public UsuarioViewModel RetornarDadosUsuario(string Codigo)
        {
            //string SQL = "SELECT * FROM Usuario where Codigo = '" + pCodigo.Codigo + "'";
            string SQL = "SELECT * FROM Usuario where Codigo = " + Codigo;

            var Dados = Ambiente.CN.Query<UsuarioViewModel>(SQL).SingleOrDefault();

            return Dados;
        }

        public UsuarioViewModel RetornarDadosFuncionario(UsuarioViewModel Nome)
        {
            string SQL = "SELECT * FROM Usuario where Nome = '" + Nome.Nome + "'";

            var Dados = Ambiente.CN.Query<UsuarioViewModel>(SQL).SingleOrDefault();

            return Dados;
        }
        public UsuarioViewModel RetornarFuncionario(string Nome)
        {
            string SQL = "SELECT * FROM Usuario where Nome = '" + Nome + "'";

            var Dados = Ambiente.CN.Query<UsuarioViewModel>(SQL).SingleOrDefault();

            return Dados;
        }

        public UsuarioViewModel RetornarDadosFuncionarioParaBusca(string Nome)
        {
            string SQL = "SELECT * FROM Usuario where Nome = @Nome";

            var Dados = Ambiente.CN.Query<UsuarioViewModel>(SQL).SingleOrDefault();

            return Dados;
        }

        public UsuarioViewModel RetornarUltimoCodigo(UsuarioViewModel pCodigo)
        {
            string SQL = "SELECT MAX(Codigo) FROM Usuario where Codigo = '" + pCodigo.Codigo + "'";

            var Dados = Ambiente.CN.Query<UsuarioViewModel>(SQL).SingleOrDefault();

            return Dados;
        }

        public List<UsuarioViewModel> ConsultarUsuarios(UsuarioViewModel pDados)
        {
            string SQL = "SELECT * FROM Usuario ORDER By Nome";

            var Data = Ambiente.CN.Query<UsuarioViewModel>(SQL).ToList();

            return Data;
        }

        public void IncluirAlterarUsuario(UsuarioViewModel pUsuario)
        {
            if (pUsuario.Id == 0)
            {
                pUsuario.Id = ObterProximo("Codigo", "Usuario");

                pUsuario.Codigo = ObterProximoCodigo("Id", "Usuario");

                string SQLIns = "INSERT INTO Usuario (Id, Codigo, Senha, Nome, Justificativa, Ativo, DataAdmissao, Funcao, CTPS, Entrada, Saida, EntradaAlmoco, SaidaAlmoco) VALUES " +
                                "(@Id, @Codigo, '123', @Nome, null, @Ativo, @DataAdmissao, @Funcao, @CTPS, @Entrada, @Saida, @EntradaAlmoco, @SaidaAlmoco)";
                Ambiente.CN.Execute(SQLIns, pUsuario);
            }
            else
            {
                string SQLIns = "UPDATE Usuario SET Nome = @Nome, Ativo = @Ativo, DataAdmissao = @DataAdmissao, Funcao = @Funcao, CTPS = @CTPS, Entrada = @Entrada, Saida = @Saida, " +
                                "EntradaAlmoco = @EntradaAlmoco, SaidaAlmoco = @SaidaAlmoco WHERE Id = @Id";
                Ambiente.CN.Execute(SQLIns, pUsuario);
            }
        }

        public bool RetornarUsuarioCadastrado(UsuarioViewModel pUsuario)
        {
            string SQL = "SELECT * FROM Usuario where Id = @Id";

            var dados = Ambiente.CN.Query<UsuarioRepository>(SQL).SingleOrDefault();

            if (dados == null)
                return false;
            else
                return true;
        }

        public bool VerificarSenhaUsuario(string Codigo)
        {
            string SQL = "SELECT * FROM Usuario where Codigo = " + Codigo;

            var Dados = Ambiente.CN.Query<UsuarioViewModel>(SQL).SingleOrDefault();

            //pSenha = Dados;

            if (Dados == null)
                return false;
            else
                return true;
        }

        internal bool VerificarSenhaUsuario(UsuarioViewModel usuarioViewModel, object pSenha)
        {
            throw new NotImplementedException();
        }

        public List<ClienteBuscaViewModel> RetornarClientesParaBusca(string pBusca)
        {
            var SQL = "SELECT * FROM Usuario ORDER BY Id";

            var data = Ambiente.CN.Query<ClienteBuscaViewModel>(SQL).ToList();

            return data;
        }

        public List<UsuarioViewModel> RetornarUsuarioParaBusca(string pBusca)
        {
            var SQL = "SELECT * FROM Usuario Where Nome LIKE'%" + pBusca + "%'";

            var data = Ambiente.CN.Query<UsuarioViewModel>(SQL).ToList();

            return data;
        }

        public void Excluir(int pId)
        {
            string SQL = "DELETE FROM Usuario WHERE Id = " + pId;
            Ambiente.CN.Execute(SQL, SQL);
        }

        public UsuarioViewModel RetornarDados(int pUsuarioId)
        {
            var SQL = "Select * FROM Usuario WHERE Id = @Id";

            var data = Ambiente.CN.Query<UsuarioViewModel>(SQL.ToString(), new { Id = pUsuarioId }).SingleOrDefault();

            return data;
        }

        public UsuarioViewModel RetornarDadosSenha()
        {
            var SQL = "Select * FROM Senha";

            var data = Ambiente.CN.Query<UsuarioViewModel>(SQL.ToString()).SingleOrDefault();

            return data;
        }

        public void AlterarSenhaUsuarioAtual(string pNovaSenha)
        {
             string SQL = "UPDATE Senha SET Senha = " + pNovaSenha;
            Ambiente.CN.Execute(SQL, SQL);
        }

        public List<UsuarioViewModel> RetornarFuncionarioParaCombo (bool pSelecione = true)
        {
            var SQL = "SELECT * FROM Usuario WHERE Ativo = 1 ORDER BY Nome";

            var data = Ambiente.CN.Query<UsuarioViewModel>(SQL.ToString(), new { Id = pSelecione }).ToList();

            if (pSelecione)
                data.Insert(0, new UsuarioViewModel() { Id = 0, Nome = "Selecione...", Ativo = true });

            return data;
        }
    }
}