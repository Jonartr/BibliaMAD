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
    public partial class Ayuda : Form
    {
     
        int Estado = 0;
        bool ok = false;
        public Ayuda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Correo = textBox1.Text;

            try
            {
               Variables_globales.conexion.EstatusUsuario(Correo);
                if(Variables_globales.Consultas.Rows.Count > 0)
                {
                     Estado = Convert.ToInt16(Variables_globales.Consultas.Rows[0]["Rehabilitado"]);
                    if (ok && Estado == 0)
                    {
                        ok = Variables_globales.conexion.Insert_Users(4, Correo);
                        MessageBox.Show("Peticion enviada, espere respuesta de administrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Cuenta activa no requiere rehabilitacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                 
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Usuario no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


      
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Revisar estatus de rehabilitacion
        private void button2_Click(object sender, EventArgs e)
        {
            var Usuario = textBox1.Text;
            try
            {
              Variables_globales.conexion.EstatusUsuario(Usuario);
                if (Variables_globales.Consultas.Rows.Count > 0)
                {
                    var Estado = Convert.ToInt16(Variables_globales.Consultas.Rows[0]["Rehabilitado"]);
                    var Estado2 = Convert.ToInt16(Variables_globales.Consultas.Rows[0]["Estatus"]);
                    if (Estado == 1 && Estado2 == 0)
                    {
                        MessageBox.Show("Rehabilitacion valida\nRegrse a inicio de sesion" +
                            "para recibir contraseña temporal", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else if (Estado2 == 1)
                    {
                        MessageBox.Show("Cuenta activa no necesita rehabilitacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Rehabilitacion en proceso, por favor siga en espera", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
