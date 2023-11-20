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
            var Id_Idioma = (int)Idioma.SelectedValue; // Ajusta según la estructura de tu ComboBox
            var Id_Testamento = (int)Testamento.SelectedValue; // Ajusta según la estructura de tu ComboBox
            var Id_Version = (int)Version.SelectedValue; // Ajusta según la estructura de tu ComboBox
            var Id_Libro = (int)Libro.SelectedValue; // Ajusta según la estructura de tu ComboBox
            var Id_Capitulo = (int)Capitulo.SelectedValue;

            if (Id_Idioma > 0) // Ajusta según la lógica de tu aplicación
            {
                ok++;
            }
            else
            {
                MessageBox.Show("Seleccione un idioma", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Validación del testamento
            if (Id_Testamento > 0) // Ajusta según la lógica de tu aplicación
            {
                ok++;
            }
            else
            {
                MessageBox.Show("Seleccione un testamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Validación de la versión
            if (Id_Version > 0) // Ajusta según la lógica de tu aplicación
            {
                ok++;
            }
            else
            {
                MessageBox.Show("Seleccione una versión", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Validación del libro
            if (Id_Libro > 0) // Ajusta según la lógica de tu aplicación
            {
                ok++;
            }
            else
            {
                MessageBox.Show("Seleccione un libro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Id_Capitulo > 0) // Ajusta según la lógica de tu aplicación
            {
                ok++;
            }
            else
            {
                MessageBox.Show("Seleccione un Capitulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Fin del resto del código de validación...

            if (ok == 5) // Ajusta según el número total de condiciones de validación
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
    }
}
