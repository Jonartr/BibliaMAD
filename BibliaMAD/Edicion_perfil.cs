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

            if (regexemail.IsMatch(Correo) && emailregister.Text != null)
            {
                ok++;
            }
            else
            {
                MessageBox.Show("Revise que el formato del correo este correcto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (regexpass.IsMatch(Contraseña) && passregister.Text != null)
            {
                ok++;
            }
            else
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres\nUna Mayúscula y Minúscula\nY un caracter especial", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


            var existe = false;
            for(int i  = 0; i <Convert.ToInt16(Variables_globales.Consultas.Rows.Count); i++)
            {
                if (Contraseña.Equals(Convert.ToString(Variables_globales.Consultas.Rows[i]["Contraseña"])))
                {
                    MessageBox.Show("La contraseña no debe ser igual a las " +
                        "\nultimas 2 contraseñas ingresadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    existe = true;
                }
               
            }

            if (!existe){
                ok++;
            }

            if (regexletter.IsMatch(Nombre) && nameregister!=null)
            {
                ok++;
            }
            else
            {
                MessageBox.Show("El nombre solo deben ser letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            else
            {
                MessageBox.Show("Seleccione un Genero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (ok == 5)
            {
                bool register = Variables_globales.conexion.Insert_Users(2 ,Correo, Contraseña, Nombre, Cumple, OpcGenero);

                if (register)
                {
                    MessageBox.Show("Informacion actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}

//stika small // book antiqua