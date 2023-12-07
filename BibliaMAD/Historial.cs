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
    public partial class Historial : Form
    {

        int idHistorial = 0;
        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            Variables_globales.Historial.Clear();
            Variables_globales.conexion.MostrarHistorialUsuarioActivo(Variables_globales.usuario);
            dataGridView1.DataSource = Variables_globales.Historial;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Borrar_completo = MessageBox.Show("¿Esta seguro de borrar esta busqueda?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Borrar_completo == DialogResult.Yes)
            {
                bool ok = Variables_globales.conexion.DeleteHistory(Variables_globales.usuario, 1, idHistorial);

                if (ok)
                {
                    MessageBox.Show("Busqueda borrada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                    Variables_globales.Historial.Clear();
                     Variables_globales.conexion.MostrarHistorialUsuarioActivo(Variables_globales.usuario);
                    dataGridView1.DataSource = Variables_globales.Historial;
                }

            }
        }

        private void BorrarHistorial_Click(object sender, EventArgs e)
        {
            var Borrar_completo = MessageBox.Show("¿Esta seguro de borrar su historial", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Borrar_completo == DialogResult.Yes)
            {
               bool ok = Variables_globales.conexion.DeleteHistory(Variables_globales.usuario, 2);

                if (ok)
                {
                    MessageBox.Show("Historial borrado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                    Variables_globales.Historial.Clear();
                }
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;

             idHistorial = Convert.ToInt16(dataGridView1.Rows[rowindex].Cells[0].Value.ToString());
            label2.Text = "Indice seleccionado: " + idHistorial.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
