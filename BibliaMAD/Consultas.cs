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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ok = 0; // Contador para validar si todo está correcto
         



            var PalabraBuscada = Palabras.Text;
            var Id_Idioma = Idioma.SelectedText;
            var Id_Testamento =Testamento.SelectedText;
            var Id_Version = Version.SelectedText;
            var Id_Libro = Libro.SelectedText;
            var Id_Capitulo = Capitulo.SelectedText;
            


            if (Id_Idioma > 0) 
            {
                ok++;
            }
            else
            {
                MessageBox.Show("Seleccione un idioma", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
            if (Id_Testamento > 0) 
            {
                ok++;
            }
            else
            {
                MessageBox.Show("Seleccione un testamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

          
            if (Id_Version > 0) 
            {
                ok++;
            }
            else
            {
                MessageBox.Show("Seleccione una versión", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

          
            if (Id_Libro > 0) 
            {
                ok++;
            }
            else
            {
                MessageBox.Show("Seleccione un libro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Id_Capitulo > 0) 
            {
                ok++;
            }
            else
            {
                MessageBox.Show("Seleccione un Capitulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

          

            if (ok == 5) 
            {
                bool searchResult = Variables_globales.conexion.BuscarPalabras(1, PalabraBuscada, Id_Idioma, Id_Testamento, Id_Version, Id_Libro,  Id_Capitulo);

                if (searchResult)
                {
                    // Si la búsqueda tiene éxito, mostrar los resultados en el DataGridView
                    Resultado.DataSource = Variables_globales.conexion.ResultadoBusqueda; ; // Ajusta según tu lógica y estructura de resultados
                    MessageBox.Show("Búsqueda realizada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            Variables_globales.conexion.Get_Books();
            /*
                      
                   Id_Idioma = (int)Idioma.SelectedValue;
                   Id_Testamento = (int)Testamento.SelectedValue;
                   Id_Version = (int)Version.SelectedValue;
                   Id_Libro = (int)Libro.SelectedValue;
                   Id_Capitulo = (int)Capitulo.SelectedValue;*/
            foreach (DataRow row in Variables_globales.Consultas.Rows)
            {
                // Llenar ComboBox para Id_Version
                if (!Idioma.Items.Contains(row["NombreIdioma"]))
                {
                    Idioma.Items.Add(row["NombreIdioma"]);
                }

              
                if (!Libro.Items.Contains(row["NombreLibro"]))
                {
                    Libro.Items.Add(row["NombreLibro"]);
                }

                if (!Version.Items.Contains(row["NombreVersion"]))
                {
                    Version.Items.Add(row["NombreVersion"]);
                }

                if (!Capitulo.Items.Contains(row["NumeroCap"]))
                {
                    Capitulo.Items.Add(row["NumeroCap"]);
                }

                if (!Testamento.Items.Contains(row["NombreTestamento"]))
                {
                    Testamento.Items.Add(row["NombreTestamento"]);
                }

            }


        }
    }
}
