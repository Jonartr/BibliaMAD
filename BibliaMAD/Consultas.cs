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

        string Idiomat = "", Testamentot = "", Versiont = "", Librot = "";
        string PalabraBuscada = "";
        int Versi = 0;


        bool filtro = true;
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

        private void Resultado_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && Resultado.Columns[e.ColumnIndex].Name == "Texto" && e.Value != null)
            {
                string texto = e.Value.ToString();
                int anchoLimite = 200; // Puedes ajustar este valor según tus necesidades
                int alturaLimite = 250; // Puedes ajustar este valor según tus necesidades

                // Mide el ancho y la altura del texto con la fuente actual
                SizeF textSize = e.Graphics.MeasureString(texto, e.CellStyle.Font, anchoLimite);

                // Si el ancho o la altura del texto supera los límites, realiza el salto de línea
                if (textSize.Width > anchoLimite || textSize.Height > alturaLimite)
                {
                    e.PaintBackground(e.CellBounds, true);

                    // Calcula el número de líneas necesarias para mostrar el texto
                    int numLineas = (int)Math.Ceiling(textSize.Height / e.CellBounds.Height);

                    // Divide el texto en líneas y dibuja cada línea en una posición diferente
                    string[] lineas = texto.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                    for (int i = 0; i < numLineas && i < lineas.Length; i++)
                    {
                        e.Graphics.DrawString(lineas[i], e.CellStyle.Font, Brushes.Black, e.CellBounds.X, e.CellBounds.Y + (i * e.CellBounds.Height));
                    }

                    e.Handled = true;
                }
            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vacio = 0;
            if (Idioma.Text != "")
            {
                if (Idioma.Text != "Todos")
                {
                    Id_Idioma = Convert.ToInt16(Idioma.Text.Substring(0, 2));
                }
               
            }
            if (Version.Text != "")
            {
                if (Version.Text != "Todos")
                {
                    Id_Version = Convert.ToInt16(Version.Text.Substring(0, 2));
                }

            }
            if (Testamento.Text != "")
            {
                if (Testamento.Text != "Todos")
                {
                    Id_Testamento = Convert.ToInt16(Testamento.Text.Substring(0, 2));
                }
                else
                {
                    Id_Testamento = 0;
                }
                  
            }
            if (Libro.Text != "")
            {
                if (Libro.Text != "Todos")
                {
                    Id_Libro = Convert.ToInt16(Libro.Text.Substring(0, 2));
                }
                else
                {
                    Id_Libro = 0;

                }
                   
            }
            
            if (Capitulo.Text != "")
            {
                if (Capitulo.Text != "Todos")
                {
                    Id_Capitulo = Convert.ToInt16(Capitulo.Text);
                }
                else
                {
                    Id_Capitulo  = 0;
                }
            }
            if (Versiculo.Text != "")
            {
           
                    Versi = Convert.ToInt16(Versiculo.Text);
            
              
            }
            else
            {
                Versi = 0;
            }

            PalabraBuscada = Palabras.Text;
                Variables_globales.Consultas.Clear();
            try
            {
                if (filtro)
                {
                    Variables_globales.conexion.BuscarPalabras(0, Variables_globales.usuario, PalabraBuscada, Id_Idioma, Id_Testamento,
                  Id_Version, Id_Libro, Versi, Id_Capitulo);

                }
                else
                {
                    Variables_globales.conexion.BuscarPalabras(3, Variables_globales.usuario, PalabraBuscada);
                }
            

                if (Variables_globales.Consultas.Rows.Count > 0 || Variables_globales.Consultas == null)
                {
                    MessageBox.Show("Busqueda realizada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Resultado.DataSource = null;
                    Resultado.DataSource = Variables_globales.Consultas;
                }
                else
                {
                    MessageBox.Show("Sin resultados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("Sin resultados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



            //Idioma.Text = "";
            //Version.Items.Clear();
            //Testamento.Items.Clear();
            //Libro.Items.Clear();
            //Capitulo.Items.Clear();
            //Versiculo.Text = "";


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = Resultado.CurrentCell.RowIndex;
            label10.Text = (Resultado.Rows[rowindex].Cells[0].Value.ToString());
            label10.MaximumSize = new Size(300, 100);
            label10.AutoSize = true;
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            Resultado.CellPainting += Resultado_CellPainting;

            Variables_globales.Consultas =  Variables_globales.conexion.Get_Books();

            groupBox1.Enabled = true;

            checkBox1.Checked = false;

         //   Idioma.Items.Add("Todos");
                foreach (DataRow row in Variables_globales.Consultas.Rows)
                {
              
                    if (!Idioma.Items.Contains(row["Nombre"])) {
                        Idioma.Items.Add(row["No. Idioma"].ToString() + " - " +row["Nombre"].ToString());
                    }
            

                }
        

        }

       

        private void button2_Click(object sender, EventArgs e)
        {

                int rowindex = Resultado.CurrentCell.RowIndex;
                var Numerovers = Convert.ToInt16(Resultado.Rows[rowindex].Cells[4].Value.ToString());
                var Texto = (Resultado.Rows[rowindex].Cells[5].Value.ToString()); 
                bool ok = Variables_globales.conexion.AddFavorite(Variables_globales.usuario, Numerovers, Texto);

                if (ok)
                {
                    MessageBox.Show("Versiculo agregado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            
        }

        private void Idioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Idioma.Text != "Todos")
            {
                Id_Idioma = Convert.ToInt16(Idioma.Text.Substring(0, 2));
            }
          
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

                Version.Items.Add("Todos");
                Testamento.Items.Add("Todos");
                if (tVersion.Rows.Count >0|| tTestamento.Rows.Count > 0)
                {
                    foreach (DataRow row in tVersion.Rows)
                    {

                        if (!Version.Items.Contains(row["Nombre"]))
                        {
                            Version.Items.Add(row["Version"].ToString() + " - " + row["Nombre"].ToString());
                        }


                    }
                    foreach (DataRow row in tTestamento.Rows)
                    {

                        if (!Testamento.Items.Contains(row["Nombre"]))
                        {
                            Testamento.Items.Add(row["Version"].ToString() + " - " + row["Nombre"].ToString());
                        }


                    }

                }
                else
                {
                    MessageBox.Show("No se encontraron resultados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
                }



            }

            catch (Exception ex)
            {
                MessageBox.Show("Error en el filtro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void Testamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Testamento.Text != "Todos")
            {
                Id_Testamento = Convert.ToInt16(Testamento.Text.Substring(0, 2));

                DataTable tLibros;


                try
                {
                    tLibros = Variables_globales.conexion.Filtro_Libros(Id_Idioma, Id_Testamento);
                    Libro.Items.Clear();
                    Libro.Items.Add("Todos");
                    foreach (DataRow row in tLibros.Rows)
                    {

                        if (!Libro.Items.Contains(row["Nombre"]))
                        {
                            Libro.Items.Add(row["No. Libro"].ToString() + " - " + row["Nombre"].ToString());
                        }


                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error en el filtro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
              
        }



        private void Version_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if(Version.Text != "")
            {
                Id_Version = Convert.ToInt16(Version.Text.Substring(0, 2));
             
            }
           
          
          
        }

        private void Libro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(Libro.Text!= "Todos")
            {
                Id_Libro = Convert.ToInt16(Libro.Text.Substring(0, 2));
            }
          

            DataTable tCaps;

            try
            {
                tCaps = Variables_globales.conexion.Filtro_Capitulos(Id_Libro, Id_Version);
                Capitulo.Items.Clear();
                Capitulo.Items.Add("Todos");
                foreach (DataRow row in tCaps.Rows)
                {

                    if (!Capitulo.Items.Contains(row["Capitulo"]))
                    {
                        Capitulo.Items.Add( row["Capitulo"].ToString());
                    }


                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error en el filtro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void Capitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Capitulo.Text != "Todos")
            {
                Id_Capitulo = Convert.ToInt16(Capitulo.Text);
            }
        

        }

        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{

        //    filtro = false;
        //}

        //private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //{

        //    filtro = true;
        //}

        private void Consultas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables_globales.consulta.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          if (!filtro)
            {
                filtro = true;
                groupBox1.Enabled = false;
            }
            else
            {
                filtro = false;
                groupBox1.Enabled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Versiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

     
    }
}



//if (!filtro)
//{
//    PalabraBuscada = Palabras.Text;

//    bool searchResult = Variables_globales.conexion.BuscarPalabras(1, Variables_globales.usuario, PalabraBuscada, Id_Idioma, Id_Testamento, Id_Version, Id_Libro, Id_Capitulo);
//    Variables_globales.conexion.AddHistory(Variables_globales.usuario, "Todos", PalabraBuscada, "Todos",
//         "Todos", "Todos", 0 ,0);


//    if (searchResult)
//    {
//        // Si la búsqueda tiene éxito, mostrar los resultados en el DataGridView

//        Resultado.DataSource = null;

//            MessageBox.Show("Búsqueda realizada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

//            Resultado.DataSource = Variables_globales.Consultas;
//    }
//    else
//    {
//        MessageBox.Show("No se encontraron resultados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
//    }
//}
//else
//{
//    try
//    {
//        var Idiomatext = Idioma.Text;
//        var Testamentotext = Testamento.Text;
//        var Versiontext = Version.Text;
//        var Librotext = Libro.Text;

//        if (Capitulo.Text!= "")
//        {
//             Id_Capitulo = Convert.ToInt16(Capitulo.Text);
//        }
//        else
//        {
//             Id_Capitulo = 0;
//        }

//        if(Versiculo.Text != "")
//        {
//            Versi = Convert.ToInt16(Versiculo.Text);

//        }
//        else
//        {
//            Versi = 0;
//        }



//        PalabraBuscada = Palabras.Text;
//        bool searchResult = Variables_globales.conexion.BuscarPalabras(2, Variables_globales.usuario, PalabraBuscada, Id_Idioma, Id_Testamento
//            , Id_Version, Id_Libro, Versi, Id_Capitulo);
//        Variables_globales.conexion.AddHistory(Variables_globales.usuario, Idiomatext, PalabraBuscada, Testamentotext,
//         Librotext, Versiontext,Versi , Id_Capitulo);
//        if (searchResult)
//        {
//            // Si la búsqueda tiene éxito, mostrar los resultados en el DataGridView

//            MessageBox.Show("Búsqueda realizada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            Resultado.DataSource = null;
//            Resultado.DataSource = Variables_globales.Consultas;
//        }
//        else
//        {
//            MessageBox.Show("No se encontraron resultados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }



//    }
//    catch (System.FormatException ex)
//    {
//        MessageBox.Show("Llene todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

//    }



//}