using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace BibliaMAD
{
    public partial class Pagina_principal : Form
    {
      
        public Pagina_principal()
        {
         

            InitializeComponent();
        }

        

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         Variables_globales.consulta.ShowDialog();
        }

        private void favoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         Variables_globales.favorito.ShowDialog();
        // Variables_globales.conexion.GetFavorite(Variables_globales.usuario);

        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Variables_globales.historial.ShowDialog();
         //  Variables_globales.conexion.MostrarHistorialUsuarioActivo(Variables_globales.usuario);
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Variables_globales.editar.ShowDialog();
    
        }

        private void inhabilitarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deshabilitar = MessageBox.Show("¿Desea deshabilitar su cuenta?", "Aviso", MessageBoxButtons.YesNo);
            if (deshabilitar == DialogResult.Yes)
            {
            bool success =  Variables_globales.conexion.DeleteHistory(Variables_globales.usuario);
                if (success)
                {
                    MessageBox.Show("Historial Borrado Correctamente", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information); ;
                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Pagina_principal_Load(object sender, EventArgs e)
        {
            label2.Text = Variables_globales.conexion.GetFavorito(Variables_globales.usuario);
            label2.MaximumSize = new Size(300,0);
            label2.AutoSize = true;
            SpeechSynthesizer audio = new SpeechSynthesizer();
            if (!string.IsNullOrEmpty(label2.Text))
            {
                audio.SpeakAsyncCancelAll();
                audio.SpeakAsync(label2.Text);
            }
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Favorito_Load(object sender, EventArgs e)
        {
         
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = Variables_globales.conexion.GetFavorito(Variables_globales.usuario);
            SpeechSynthesizer audio = new SpeechSynthesizer();
            if (!string.IsNullOrEmpty(label2.Text))
            {
                audio.SpeakAsyncCancelAll();
                audio.SpeakAsync(label2.Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Pagina_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Variables_globales.isesion.Show();
        }
    }
}
