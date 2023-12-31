﻿using System;
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
    public partial class Registro : Form
    {
        public Registro()
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

        private void Registro_Load(object sender, EventArgs e)
        {

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
            var Contraseña2 = passregister2.Text;
            var Nombre = nameregister.Text;
            var Genero = genreregister.Text;
            var Cumple = dateregister.Value;
            var OpcGenero = 0;

            if (regexemail.IsMatch(Correo))
            {
                ok++;
            }
            else
            {
                MessageBox.Show("Revise que el formato del correo este correcto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (regexpass.IsMatch(Contraseña))
            {
                ok++;
            }
            else
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres\nUna Mayúscula y Minúscula\nY un caracter especial", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
   
            }

            if (Contraseña.Equals(Contraseña2))
            {
                ok++;
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (regexletter.IsMatch(Nombre))
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

            if(ok == 5)
            {
              bool register = Variables_globales.conexion.Insert_Users(1 ,Correo, Contraseña, Nombre, Cumple, OpcGenero);

                if (register)
                {
                    MessageBox.Show("Usuario Registrado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    emailregister.Text = "";
                    passregister.Text = "";
                    passregister2.Text = "";
                    nameregister.Text = "";
                    genreregister.Text = "";

                    this.Close();

                
                }
            }

        }

        private void nameregister_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

//stika small // book antiqua