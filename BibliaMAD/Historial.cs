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
        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {

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
    }
}
