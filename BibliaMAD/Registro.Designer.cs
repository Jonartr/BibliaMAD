namespace BibliaMAD
{
    partial class Registro
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
            this.label1 = new System.Windows.Forms.Label();
            this.emailregister = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passregister = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameregister = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateregister = new System.Windows.Forms.DateTimePicker();
            this.genreregister = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passregister2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.registerbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailregister
            // 
            this.emailregister.Location = new System.Drawing.Point(142, 32);
            this.emailregister.Margin = new System.Windows.Forms.Padding(3, 6, 3, 18);
            this.emailregister.Name = "emailregister";
            this.emailregister.Size = new System.Drawing.Size(266, 30);
            this.emailregister.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correo electronico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña:";
            // 
            // passregister
            // 
            this.passregister.Location = new System.Drawing.Point(142, 81);
            this.passregister.Margin = new System.Windows.Forms.Padding(3, 6, 3, 18);
            this.passregister.Name = "passregister";
            this.passregister.PasswordChar = '*';
            this.passregister.Size = new System.Drawing.Size(266, 30);
            this.passregister.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre completo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nameregister
            // 
            this.nameregister.Location = new System.Drawing.Point(142, 181);
            this.nameregister.Margin = new System.Windows.Forms.Padding(3, 6, 3, 18);
            this.nameregister.Name = "nameregister";
            this.nameregister.Size = new System.Drawing.Size(266, 30);
            this.nameregister.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 282);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 6, 3, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Genero:";
            // 
            // dateregister
            // 
            this.dateregister.Location = new System.Drawing.Point(142, 229);
            this.dateregister.Margin = new System.Windows.Forms.Padding(3, 6, 3, 18);
            this.dateregister.Name = "dateregister";
            this.dateregister.Size = new System.Drawing.Size(287, 30);
            this.dateregister.TabIndex = 11;
            // 
            // genreregister
            // 
            this.genreregister.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreregister.FormattingEnabled = true;
            this.genreregister.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.genreregister.Location = new System.Drawing.Point(142, 278);
            this.genreregister.Margin = new System.Windows.Forms.Padding(3, 6, 3, 18);
            this.genreregister.Name = "genreregister";
            this.genreregister.Size = new System.Drawing.Size(181, 30);
            this.genreregister.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passregister2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.genreregister);
            this.groupBox1.Controls.Add(this.emailregister);
            this.groupBox1.Controls.Add(this.dateregister);
            this.groupBox1.Controls.Add(this.passregister);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nameregister);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(14, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(558, 350);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del perfil";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // passregister2
            // 
            this.passregister2.Location = new System.Drawing.Point(142, 130);
            this.passregister2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 18);
            this.passregister2.Name = "passregister2";
            this.passregister2.PasswordChar = '*';
            this.passregister2.Size = new System.Drawing.Size(266, 30);
            this.passregister2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 6, 3, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Confirmar contraseña:";
            // 
            // registerbutton
            // 
            this.registerbutton.Location = new System.Drawing.Point(156, 482);
            this.registerbutton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(87, 27);
            this.registerbutton.TabIndex = 14;
            this.registerbutton.Text = "Registrar";
            this.registerbutton.UseVisualStyleBackColor = true;
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 554);
            this.Controls.Add(this.registerbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailregister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passregister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameregister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateregister;
        private System.Windows.Forms.ComboBox genreregister;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passregister2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button registerbutton;
    }
}