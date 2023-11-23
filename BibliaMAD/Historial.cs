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
        private string correoUsuarioActual;
        public Historial()
        {
            InitializeComponent();
            this.Load += Historial_Load;
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            
            DataTable datos = Variables_globales.conexion.MostrarHistorialUsuarioActivo(correoUsuarioActual);

            
            dataGridView1.DataSource = datos;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BorrarHistorial_Click(object sender, EventArgs e)
        {
            var Borrar_completo = MessageBox.Show("¿Esta seguro de borrar su historial", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Borrar_completo == DialogResult.Yes)
            {
                Variables_globales.conexion.Insert_Users(3, Variables_globales.usuario);
                MessageBox.Show("Cuenta Deshabilitada,\ncontacte a un adminstrador en caso" +
                    " de querer reingresar, hasta luego", "Aviso", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
