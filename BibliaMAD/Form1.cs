using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliaMAD.Properties;

namespace BibliaMAD
{
    public partial class Inicio_sesion : Form
    {
       
       
        public Inicio_sesion()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_sesion_Load(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            var Correo = email.Text;
            var Contraseña = password.Text;
            var Admin = 1;
            if (checkadmin.Checked)
            {
                //SE PONE 1 SI ES USUARIO, SE PONE 2 SI ES ADMINISTRADOR
                Admin = 2;
            }

            bool existe = Variables_globales.conexion.Autentificar(Correo, Contraseña, Admin);
            if (checkadmin.Checked)
            {

            }


            if (existe == true)
            {
              if(Admin == 1) 
              {
                    if (Variables_globales.estatus == 1)
                    {
                            var perfil = new Pagina_principal();
                            Variables_globales.inicio.ShowDialog();
                    }
                    else
                    {
                        if (Variables_globales.estatus == 0 && Variables_globales.intentos > 0)
                        {
                            MessageBox.Show("Este correo esta deshabilitado" +
                          "\ncontacte a un administrador para rehabilitarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } 
                        else if (Variables_globales.estatus == 0 && Variables_globales.intentos == 0)
                        {
                            MessageBox.Show("Este correo esta deshabilitado por ingreso de contraseñas incorrectas" +
                         "\ncontacte a un administrador para rehabilitarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }
              }
              else if (Admin == 2)
              {
                        var administrador = new Administrador();
                        Variables_globales.adminis.ShowDialog();
              }
               
              
            }
            else
            {
                MessageBox.Show("Correo no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          Variables_globales.registro.ShowDialog();
        }

        private void checkadmin_CheckedChanged(object sender, EventArgs e)
        {

            Variables_globales.admin = !Variables_globales.admin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
      //      var conectar = new EnlaceDB();
        //    conectar.get_Users();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          Variables_globales.help.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
