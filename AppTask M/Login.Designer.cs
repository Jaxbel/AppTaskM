namespace AppTask_M
{
    partial class Login
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
            this.Titulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.Recordarme = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(271, 120);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(259, 25);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "App Task Management";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "¿Aún no tienes una cuenta?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(276, 198);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(254, 20);
            this.usuario.TabIndex = 3;
            this.usuario.Text = "Usuario";
            this.usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(276, 224);
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.Size = new System.Drawing.Size(254, 20);
            this.contraseña.TabIndex = 4;
            this.contraseña.Text = "Contraseña";
            // 
            // Recordarme
            // 
            this.Recordarme.AutoSize = true;
            this.Recordarme.Location = new System.Drawing.Point(276, 250);
            this.Recordarme.Name = "Recordarme";
            this.Recordarme.Size = new System.Drawing.Size(84, 17);
            this.Recordarme.TabIndex = 5;
            this.Recordarme.Text = "Recordarme";
            this.Recordarme.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Olvidé mi contraseña";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Iniciar Sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AppTask_M.Properties.Resources.cabecera;
            this.pictureBox1.InitialImage = global::AppTask_M.Properties.Resources.cabecera;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1441, 119);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Recordarme);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Titulo);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.CheckBox Recordarme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}