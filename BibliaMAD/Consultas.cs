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


            int Id_Idioma = 0;
            int Id_Testamento = 0;
            int Id_Version = 0;
            int Id_Libro = 0;
            int Id_Capitulo = 0;

            var PalabraBuscada = Palabras.Text;
            var TextIdioma = Idioma.Text;
            var TextTestamento = Testamento.Text;
            var TextVersion = Version.Text; 
            var TextLibro = Libro.Text;
            Id_Capitulo = Convert.ToInt16(Capitulo.Text);




            if (TextIdioma.Equals("Español"))
            {
                Id_Idioma = 1;
                ok++;
            }
            else
            {
                MessageBox.Show("Seleccione un idioma", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (TextTestamento.Equals("ANTIGUO TESTAMENTO"))
            {
                Id_Testamento = 1;
                ok++;
            }
            else
            {
                MessageBox.Show("Seleccione un testamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (TextVersion.Equals("REINA VALERA 1960"))
            {
                Id_Version = 1; 
                ok++;
            }
            else
            {
                MessageBox.Show("Seleccione una versión", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (TextLibro.Equals("Génesis"))
            {
                Id_Libro = 1;
                ok++;
            }
            else
            {
                MessageBox.Show("Seleccione una versión", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            //if (Id_Libro > 0) 
            //{
            //    ok++;
            //}
            //else
            //{
            //    MessageBox.Show("Seleccione un libro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            if (Id_Capitulo != 0)
            {
                ok++;
            }
            else
            {
                MessageBox.Show("Seleccione un Capitulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            if (ok == 5) 
            {
                bool searchResult = Variables_globales.conexion.BuscarPalabras(Variables_globales.usuario,PalabraBuscada, Id_Idioma, Id_Testamento, Id_Version, Id_Libro,  Id_Capitulo);

                if (searchResult)
                {
                    // Si la búsqueda tiene éxito, mostrar los resultados en el DataGridView
       
                    MessageBox.Show("Búsqueda realizada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Resultado.DataSource = null;
                    Resultado.DataSource = Variables_globales.Consultas;

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
              
                if (!Idioma.Items.Contains(row["NombreIdioma"]))
                {
                    Idioma.Items.Add(row["NombreIdioma"].ToString());
                }

              
                if (!Libro.Items.Contains(row["NombreLibro"]))
                {
                    Libro.Items.Add(row["NombreLibro"].ToString());
                }

                if (!Version.Items.Contains(row["NombreVersion"]))
                {
                    Version.Items.Add(row["NombreVersion"].ToString());
                }

                if (!Capitulo.Items.Contains(row["NumeroCap"]))
                {
                    Capitulo.Items.Add(row["NumeroCap"].ToString());
                }

                if (!Testamento.Items.Contains(row["NombreTestamento"]))
                {
                    Testamento.Items.Add(row["NombreTestamento"].ToString());
                }

            }


        }

        private void Capitulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Resultado.SelectedRows.Count > 0){
                DataGridViewRow fila =  Resultado.SelectedRows[0];

                int NumeroVers = Convert.ToInt16(fila.Cells[3].Value.ToString());
                string Texto = fila.Cells[4].Value.ToString();

                bool ok = Variables_globales.conexion.AddFavorite(Variables_globales.usuario, NumeroVers, Texto);

                if (ok)
                {
                    MessageBox.Show("Versiculo agregado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
        }
    }
}
