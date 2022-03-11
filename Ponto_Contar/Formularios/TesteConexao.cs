using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dapper;
using Ponto_Contar.Classes.ViewModel;

namespace Ponto_Contar
{
    public partial class TesteConexao : Form
    {
        public TesteConexao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT * FROM Usuario ORDER BY Nome";

            var Dados = Ambiente.CN.Query<UsuarioViewModel>(SQL).ToList();

            foreach (var DadosUsuario in Dados)
            {
                string Valor = DadosUsuario.Nome + "  ||  " + DadosUsuario.Codigo;

                listBox1.Items.Add(Valor);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}