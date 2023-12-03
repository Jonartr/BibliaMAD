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
        public Favoritos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Favoritos_Load(object sender, EventArgs e)
        {
            Variables_globales.conexion.GetFavorite(Variables_globales.usuario);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Variables_globales.Consultas;
        }
    }
}
