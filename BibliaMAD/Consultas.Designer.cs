﻿namespace BibliaMAD
{
    partial class Consultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Capitulo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Palabras = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Idioma = new System.Windows.Forms.ComboBox();
            this.Testamento = new System.Windows.Forms.ComboBox();
            this.Version = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Libro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // Capitulo
            // 
            this.Capitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Capitulo.FormattingEnabled = true;
            this.Capitulo.Location = new System.Drawing.Point(79, 36);
            this.Capitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Capitulo.Name = "Capitulo";
            this.Capitulo.Size = new System.Drawing.Size(140, 24);
            this.Capitulo.TabIndex = 3;
            this.Capitulo.SelectedIndexChanged += new System.EventHandler(this.Capitulo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Capitulo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Libro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(698, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Palabra en especifico";
            // 
            // Palabras
            // 
            this.Palabras.Location = new System.Drawing.Point(688, 199);
            this.Palabras.Name = "Palabras";
            this.Palabras.Size = new System.Drawing.Size(147, 22);
            this.Palabras.TabIndex = 10;
            // 
            // Resultado
            // 
            this.Resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Resultado.Location = new System.Drawing.Point(21, 305);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(900, 237);
            this.Resultado.TabIndex = 12;
            this.Resultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Resultados encontrados";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "Agregar a favoritos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Idioma
            // 
            this.Idioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Idioma.FormattingEnabled = true;
            this.Idioma.Location = new System.Drawing.Point(79, 146);
            this.Idioma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Idioma.Name = "Idioma";
            this.Idioma.Size = new System.Drawing.Size(140, 24);
            this.Idioma.TabIndex = 16;
            // 
            // Testamento
            // 
            this.Testamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Testamento.FormattingEnabled = true;
            this.Testamento.Location = new System.Drawing.Point(314, 146);
            this.Testamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Testamento.Name = "Testamento";
            this.Testamento.Size = new System.Drawing.Size(248, 24);
            this.Testamento.TabIndex = 17;
            // 
            // Version
            // 
            this.Version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Version.FormattingEnabled = true;
            this.Version.Location = new System.Drawing.Point(555, 36);
            this.Version.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(140, 24);
            this.Version.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Testamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Version";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Idioma";
            // 
            // Libro
            // 
            this.Libro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Libro.FormattingEnabled = true;
            this.Libro.Location = new System.Drawing.Point(287, 36);
            this.Libro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Libro.Name = "Libro";
            this.Libro.Size = new System.Drawing.Size(140, 24);
            this.Libro.TabIndex = 22;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.Libro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Testamento);
            this.Controls.Add(this.Idioma);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Palabras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Capitulo);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Capitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Palabras;
        private System.Windows.Forms.DataGridView Resultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox Idioma;
        private System.Windows.Forms.ComboBox Testamento;
        private System.Windows.Forms.ComboBox Version;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Libro;
    }
}