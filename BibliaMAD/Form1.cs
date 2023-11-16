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
            if (Variables_globales.admin)
            {
            //    var administrador = new Administrador();
                Variables_globales.adminis.ShowDialog();
            }
            else
            {
          //     var perfil = new Pagina_principal();
                Variables_globales.inicio.ShowDialog();

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
