﻿using System;
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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Desea rehabilitarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }
    }
}
