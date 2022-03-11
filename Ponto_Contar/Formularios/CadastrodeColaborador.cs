using Ponto_Contar.Classes.Repository;
using Ponto_Contar.Classes.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ponto_Contar
{
    public partial class CadastrodeColaborador : Form
    {
        public ClienteBuscaViewModel DadosCliente { get; set; }
        public string Nome { get; set; }
        public string Ativo { get; set; }
        private DataTable _DTColaborador = new DataTable();

        public CadastrodeColaborador()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarColaborador();
        }

        private void CadastrodeColaborador_Load(object sender, EventArgs e)
        {
            string Busca = "";

            _DTColaborador = new DataTable();
            _DTColaborador.Columns.Add("Id", Type.GetType("System.Int32"));
            _DTColaborador.Columns.Add("Codigo", Type.GetType("System.String"));
            _DTColaborador.Columns.Add("Nome", Type.GetType("System.String"));
            _DTColaborador.Columns.Add("Ativo", Type.GetType("System.Boolean"));

            GridColaborador.DataSource = _DTColaborador;

            GridColaborador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridColaborador.RowHeadersVisible = false;
            GridColaborador.AllowUserToAddRows = false;
            GridColaborador.ReadOnly = true;
            GridColaborador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            GridColaborador.Columns["Id"].Visible = false;
            //GridColaborador.Columns["Senha"].Visible = false;

            GridColaborador.Columns["Codigo"].Width = 80;
            GridColaborador.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GridColaborador.Columns["Ativo"].Width = 80;

            if (GridColaborador.Rows.Count > 0)
                GridColaborador.Focus();
        }

        private void BuscarColaborador()
        {
            string Busca = txtBusca.Text;
            var ColaboradorRep = new UsuarioRepository();

            //var Dados = ColaboradorRep.RetornarUsuarioParaBusca(Busca);RetornarClientesParaBusca
            var Dados = ColaboradorRep.RetornarClientesParaBusca(Busca);

            _DTColaborador.Rows.Clear();

            foreach (var Item in Dados)
            {
                var Novo = _DTColaborador.NewRow();
                Novo["Id"] = Item.Id;
                Novo["Codigo"] = Item.Codigo;
                Novo["Nome"] = Item.Nome;
                Novo["Ativo"] = Item.Ativo;

                _DTColaborador.Rows.Add(Novo);
            }

            if (GridColaborador.Rows.Count > 0)
                GridColaborador.Focus();
            else
                txtBusca.Focus();
            txtBusca.SelectAll();
        }

        private void cmdIncluir_Click(object sender, EventArgs e)
        {
            var Frm = new IncluirAlterarColaborador();
            Frm.ShowDialog();

            BuscarColaborador();
        }
        
        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            if (GridColaborador.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Colaborador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var DadosColaborador = int.Parse(GridColaborador.SelectedRows[0].Cells["Id"].Value.ToString());

            var Frm = new IncluirAlterarColaborador();
            Frm.CodigoRegistro = DadosColaborador;
            Frm.ShowDialog();

            BuscarColaborador();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (GridColaborador.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            var ClienteId = int.Parse(GridColaborador.SelectedRows[0].Cells["Id"].Value.ToString());

            if (MessageBox.Show("Confirma a exclusão do registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            var ClienteRep = new UsuarioRepository();

            try
            {
                ClienteRep.Excluir(ClienteId);
            }
            catch
            {
                MessageBox.Show("Não foi possível excluir o registro.  Ele pode estar vinculado a algum lançamento no sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            BuscarColaborador();
        }
    }
}
