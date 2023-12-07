namespace BibliaMAD
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Versiculo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Resultado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Capitulo
            // 
            this.Capitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Capitulo.FormattingEnabled = true;
            this.Capitulo.Location = new System.Drawing.Point(483, 90);
            this.Capitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Capitulo.Name = "Capitulo";
            this.Capitulo.Size = new System.Drawing.Size(140, 24);
            this.Capitulo.TabIndex = 3;
            this.Capitulo.SelectedIndexChanged += new System.EventHandler(this.Capitulo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Capitulo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Libro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Palabra en especifico";
            // 
            // Palabras
            // 
            this.Palabras.Location = new System.Drawing.Point(165, 241);
            this.Palabras.Name = "Palabras";
            this.Palabras.Size = new System.Drawing.Size(147, 22);
            this.Palabras.TabIndex = 10;
            // 
            // Resultado
            // 
            this.Resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Resultado.Location = new System.Drawing.Point(21, 375);
            this.Resultado.Name = "Resultado";
            this.Resultado.RowHeadersWidth = 62;
            this.Resultado.Size = new System.Drawing.Size(660, 237);
            this.Resultado.TabIndex = 12;
            this.Resultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Resultados encontrados";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 289);
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
            this.Idioma.Location = new System.Drawing.Point(58, 29);
            this.Idioma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Idioma.Name = "Idioma";
            this.Idioma.Size = new System.Drawing.Size(140, 24);
            this.Idioma.TabIndex = 16;
            this.Idioma.SelectedIndexChanged += new System.EventHandler(this.Idioma_SelectedIndexChanged);
            // 
            // Testamento
            // 
            this.Testamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Testamento.FormattingEnabled = true;
            this.Testamento.Location = new System.Drawing.Point(291, 32);
            this.Testamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Testamento.Name = "Testamento";
            this.Testamento.Size = new System.Drawing.Size(248, 24);
            this.Testamento.TabIndex = 17;
            this.Testamento.SelectedIndexChanged += new System.EventHandler(this.Testamento_SelectedIndexChanged);
            // 
            // Version
            // 
            this.Version.BackColor = System.Drawing.SystemColors.Window;
            this.Version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Version.FormattingEnabled = true;
            this.Version.Location = new System.Drawing.Point(58, 87);
            this.Version.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(140, 24);
            this.Version.TabIndex = 18;
            this.Version.SelectedIndexChanged += new System.EventHandler(this.Version_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Testamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Version";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Idioma";
            // 
            // Libro
            // 
            this.Libro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Libro.FormattingEnabled = true;
            this.Libro.Location = new System.Drawing.Point(269, 90);
            this.Libro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Libro.Name = "Libro";
            this.Libro.Size = new System.Drawing.Size(140, 24);
            this.Libro.TabIndex = 22;
            this.Libro.SelectedIndexChanged += new System.EventHandler(this.Libro_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 20);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Todos";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(144, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 20);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Filtrar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Versiculo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Idioma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Capitulo);
            this.groupBox1.Controls.Add(this.Libro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Testamento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Version);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 179);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "so ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Solo números";
            // 
            // Versiculo
            // 
            this.Versiculo.Location = new System.Drawing.Point(71, 143);
            this.Versiculo.Name = "Versiculo";
            this.Versiculo.Size = new System.Drawing.Size(100, 22);
            this.Versiculo.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Versiculo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Versiculo:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 642);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Palabras);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Consultas_FormClosed);
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Resultado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Versiculo;
        private System.Windows.Forms.Label label10;
    }
}