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


        int Id_Idioma = 0;
        int Id_Testamento = 0;
        int Id_Version = 0;
        int Id_Libro = 0;
        int Id_Capitulo = 0;
        string PalabraBuscada = "";


        bool filtro = false;
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
        



            if (!filtro)
            {
                PalabraBuscada = Palabras.Text;
                Variables_globales.Consultas = null;
                bool searchResult = Variables_globales.conexion.BuscarPalabras(1, Variables_globales.usuario, PalabraBuscada, Id_Idioma, Id_Testamento, Id_Version, Id_Libro, Id_Capitulo);

                if (searchResult)
                {
                    // Si la búsqueda tiene éxito, mostrar los resultados en el DataGridView

                    Resultado.DataSource = null;
                    if(Variables_globales.Consultas.Rows.Count > 0)
                    {
                        MessageBox.Show("Búsqueda realizada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Resultado.DataSource = Variables_globales.Consultas;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                }
                else
                {
                    MessageBox.Show("No se encontraron resultados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                try
                {
                    bool searchResult = Variables_globales.conexion.BuscarPalabras(2, Variables_globales.usuario, PalabraBuscada, Id_Idioma, Id_Testamento, Id_Version, Id_Libro, Id_Capitulo);

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
                catch (System.FormatException ex)
                {
                    MessageBox.Show("Llene todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }



            }
        
           


         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Consultas_Load(object sender, EventArgs e)
        {
         Variables_globales.Consultas =  Variables_globales.conexion.Get_Books();


                foreach (DataRow row in Variables_globales.Consultas.Rows)
                {
              
                    if (!Idioma.Items.Contains(row["Nombre"])) {
                        Idioma.Items.Add(row["Nombre"].ToString());
                    }
            

                }
            radioButton1.Checked = true;

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

        private void Idioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id_Idioma = Convert.ToInt16(Idioma.SelectedIndex) + 1;
            DataTable tVersion;
            DataTable tTestamento;
            try
            {
                tVersion = Variables_globales.conexion.Filtro_version(Id_Idioma);
                tTestamento = Variables_globales.conexion.Filtro_Testamento(Id_Idioma);
                Version.Items.Clear();
                Testamento.Items.Clear();
                Libro.Items.Clear();
                Capitulo.Items.Clear();
                Libro.Enabled = false;
                Capitulo.Enabled = false;
                foreach (DataRow row in tVersion.Rows)
                {

                    if (!Version.Items.Contains(row["Nombre"]))
                    {
                        Version.Items.Add(row["Nombre"].ToString());
                    }


                }
                foreach (DataRow row in tTestamento.Rows)
                {

                    if (!Testamento.Items.Contains(row["Nombre"]))
                    {
                        Testamento.Items.Add(row["Nombre"].ToString());
                    }


                }

                Version.Enabled = true;
                Testamento.Enabled = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error en el filtro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void Testamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id_Testamento = Convert.ToInt16(Testamento.SelectedIndex) + 1;
        }



        private void Version_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id_Version = Convert.ToInt16(Version.SelectedIndex) + 1;
            DataTable tLibros;
          
        if(Id_Testamento != 0 && Id_Version != 0)
            {
                try
                {
                    tLibros = Variables_globales.conexion.Filtro_Libros(Id_Idioma, Id_Testamento);
                    Libro.Items.Clear();
                    foreach (DataRow row in tLibros.Rows)
                    {

                        if (!Libro.Items.Contains(row["Nombre"]))
                        {
                            Libro.Items.Add(row["No. Libro"].ToString() + " " + row["Nombre"].ToString());
                        }


                    }
                    Libro.Enabled = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error en el filtro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
          
        }

        private void Libro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idlibro = Convert.ToInt16(Libro.Text.Substring(0, 2));
            Id_Libro = idlibro;

            DataTable tCaps;


            try
            {
                tCaps = Variables_globales.conexion.Filtro_Capitulos(idlibro);
                Capitulo.Items.Clear();
                foreach (DataRow row in tCaps.Rows)
                {

                    if (!Capitulo.Items.Contains(row["Capitulo"]))
                    {
                        Capitulo.Items.Add( row["Capitulo"].ToString());
                    }


                }
                Capitulo.Enabled = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error en el filtro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void Capitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
          Id_Capitulo = Convert.ToInt16(Capitulo.Text);        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            filtro = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            filtro = true;
        }

      
    }
}
