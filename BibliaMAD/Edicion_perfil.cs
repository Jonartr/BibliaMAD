using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BibliaMAD
{
    public partial class Edicion_perfil : Form
    {
        public Edicion_perfil()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Edicion_perfil_Load(object sender, EventArgs e)
        {
            try
            {
                Variables_globales.conexion.EDGetUser(Variables_globales.usuario);
                emailregister.Text = Convert.ToString(Variables_globales.Consultas.Rows[0]["Correo"]);
                nameregister.Text = Convert.ToString(Variables_globales.Consultas.Rows[0]["Nombre"]);
                dateregister.Value = Convert.ToDateTime(Variables_globales.Consultas.Rows[0]["Fecha_nacimiento"]);
                genreregister.Text = Convert.ToString(Variables_globales.Consultas.Rows[0]["Genero"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            //Regex para validaciones 
            string isEmail = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            string isPass = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            string isLetter = @"^[a-zA-Z ]+$";



            Regex regexemail = new Regex(isEmail);
            Regex regexpass = new Regex(isPass);
            Regex regexletter = new Regex(isLetter);
            int ok = 0;//Contador para validar si todo esta correcto

            var Correo = emailregister.Text;
            var Contraseña = passregister.Text;
          //  var Contraseña2 = passregister2.Text;
            var Nombre = nameregister.Text;
            var Genero = genreregister.Text;
            var Cumple = dateregister.Value;
            var OpcGenero = 0;

        

        

            var existe = false;
          

            if (passregister.Text != "")
            {

                if (passregister.Text != "")
                {
                    if (regexpass.IsMatch(Contraseña))
                    {

                        for (int i = 0; i < Convert.ToInt16(Variables_globales.Consultas.Rows.Count); i++)
                        {
                            if (Contraseña.Equals(Convert.ToString(Variables_globales.Consultas.Rows[i]["Contraseña"])))
                            {
                                MessageBox.Show("La contraseña no debe ser igual a las " +
                                    "\nultimas 2 contraseñas ingresadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                existe = true;
                            }
                          

                        }

                        if (!existe)
                        {
                            ok++;
                        }
                       
                    }
                    else
                    { 
                        MessageBox.Show("La contraseña debe tener al menos 8 caracteres\nUna Mayúscula y Minúscula\nY un caracter especial", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
              
            }
            else
            {
                for (int i = 0; i < Convert.ToInt16(Variables_globales.Consultas.Rows.Count); i++)
                {
                    if (2.Equals(Convert.ToInt16(Variables_globales.Consultas.Rows[i]["Indice_Contraseña"])))
                    {
                        Contraseña = Convert.ToString(Variables_globales.Consultas.Rows[i]["Contraseña"]);
                        ok++;
                    }

                }
            }

            if (Genero.Equals("Masculino"))
            {
                OpcGenero = 1;
                ok++;
            }
            else if (Genero.Equals("Femenino"))
            {
                OpcGenero = 2;
                ok++;
            }

            if(ok == 2)
            {
                bool register = Variables_globales.conexion.Insert_Users(2, Correo, Contraseña, Nombre, Cumple, OpcGenero);
                Variables_globales.conexion.EDGetUser(Variables_globales.usuario);

                if (register)
                {
                    MessageBox.Show("Informacion actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 emailregister.Text = "";
                 passregister.Text = "";
                  nameregister.Text = "";
                  genreregister.Text = "";
                  dateregister.Value= "";
                    this.Close();

                }
            }
         
        }
    }
}

//stika small // book antiqua