using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliaMAD
{
    public partial class Administrador : Form
    {
        int idU = 0;
        public Administrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Desea rehabilitarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
          Variables_globales.conexion.get_Users();
            dataGridView1.DataSource = Variables_globales.Consultas;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;

          
            label1.Text = "Indice seleccionado: " + (rowindex + 1).ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
