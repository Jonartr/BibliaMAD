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
    public partial class Favoritos : Form
    {
        int idFav = 0;
        public Favoritos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Favoritos_Load(object sender, EventArgs e)
        {
            Variables_globales.Fav.Clear();
             Variables_globales.conexion.GetFavorite(Variables_globales.usuario);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Variables_globales.Fav;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;

            idFav = Convert.ToInt16(dataGridView1.Rows[rowindex].Cells[0].Value.ToString());
            label2.Text = "Indice seleccionado: " + idFav.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        var delete =  MessageBox.Show("¿Desea borrar todos sus favoritos?"
                + "\nEsta accion no se podra deshacer","Aviso" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(delete == DialogResult.Yes)
            {
                Variables_globales.conexion.DeleteFavorite(Variables_globales.usuario, 1);
                MessageBox.Show("Favorito borrado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Variables_globales.Fav.Clear();
                Variables_globales.conexion.GetFavorite(Variables_globales.usuario);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Variables_globales.Fav;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var delete = MessageBox.Show("¿Desea borrar este favorito?"
              + "\nEsta accion no se podra deshacer", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (delete == DialogResult.Yes)
            {
                Variables_globales.conexion.DeleteFavorite(Variables_globales.usuario, 2, idFav);
                MessageBox.Show("Favoritos borrados con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Variables_globales.Fav.Clear();
                Variables_globales.conexion.GetFavorite(Variables_globales.usuario);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Variables_globales.Fav;
            }
        }

        private void Favoritos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables_globales.favorito.Close();
        }
    }
}
