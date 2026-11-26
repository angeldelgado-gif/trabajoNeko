namespace panaderia_neko_pan
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            lblnombre = new Label();
            btnRegistro = new Button();
            btnConsulta = new Button();
            btnCerrar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe Print", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(185, 11);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(453, 70);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Panaderia Neko-Pan";
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.FromArgb(255, 211, 182);
            btnRegistro.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistro.Location = new Point(211, 283);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(159, 55);
            btnRegistro.TabIndex = 2;
            btnRegistro.Text = "Registro de informacion";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.BackColor = Color.FromArgb(255, 211, 182);
            btnConsulta.Font = new Font("Trebuchet MS", 8.25F);
            btnConsulta.Location = new Point(442, 283);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(159, 55);
            btnConsulta.TabIndex = 3;
            btnConsulta.Text = "Consulta de informacion";
            btnConsulta.UseVisualStyleBackColor = false;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(255, 182, 200);
            btnCerrar.Font = new Font("Trebuchet MS", 8.25F);
            btnCerrar.Location = new Point(325, 360);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(159, 55);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Salir";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(281, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 233);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnCerrar);
            Controls.Add(btnConsulta);
            Controls.Add(btnRegistro);
            Controls.Add(lblnombre);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panaderia Neko Pan";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnombre;
        private Button btnRegistro;
        private Button btnConsulta;
        private Button btnCerrar;
        private PictureBox pictureBox1;
    }
}
