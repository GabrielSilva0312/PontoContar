using System;
using System.Windows.Forms;

namespace Ponto_Contar
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            var U = new Usuario();
            var Lista = U.RetornarUsuariosNoDisco();

            foreach (var Item in Lista)
                lstUsuarios.Items.Add(Item);

        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
           /* var P = new Ponto();
            var RetornarLista = P.RetornarListaItensPonto(lstUsuarios.Text,txtDataInicial.Value, txtDataFinal.Value);

            dataGridView1.DataSource = RetornarLista;

            dataGridView1.Columns["Nome"].Width = 95;
            dataGridView1.Columns["Data"].DefaultCellStyle.Format = "dd/MM > HH:mm";
            dataGridView1.Columns["Justificativa"].Width = 250;
            dataGridView1.Columns["NomeMaquina"].Width = 80;
            dataGridView1.Columns["Data"].Width = 80;
            dataGridView1.Columns["Ip"].Width = 95;*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
