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
    public partial class Pagina_principal : Form
    {
      
        public Pagina_principal()
        {
         

            InitializeComponent();
        }

        

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         Variables_globales.consulta.ShowDialog();
        }

        private void favoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         Variables_globales.favorito.ShowDialog();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Variables_globales.historial.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Variables_globales.editar.ShowDialog();
    
        }

        private void inhabilitarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deshabilitar = MessageBox.Show("¿Desea deshabilitar su cuenta?", "Aviso", MessageBoxButtons.YesNo);
           if (deshabilitar == DialogResult.Yes)
            {
                Variables_globales.conexion.Insert_Users(3, Variables_globales.usuario);
                MessageBox.Show("Cuenta Deshabilitada,\ncontacte a un adminstrador en caso" +
                    " de querer reingresar, hasta luego", "Aviso", MessageBoxButtons.OK);
                this.Close();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

     
    }
}
