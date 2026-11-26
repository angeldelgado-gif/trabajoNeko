namespace panaderia_neko_pan
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            lblBuscarcliente = new Label();
            cbxBuscarcliente = new ComboBox();
            lblTextobuscar = new Label();
            txtNumeropedido = new TextBox();
            btnBuscar = new Button();
            btnVertodo = new Button();
            dataGridView1 = new DataGridView();
            lblResumen = new Label();
            lblResumen2 = new Label();
            btnAtras = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblBuscarcliente
            // 
            lblBuscarcliente.AutoSize = true;
            lblBuscarcliente.Font = new Font("Trebuchet MS", 8.25F);
            lblBuscarcliente.Location = new Point(49, 29);
            lblBuscarcliente.Name = "lblBuscarcliente";
            lblBuscarcliente.Size = new Size(79, 16);
            lblBuscarcliente.TabIndex = 3;
            lblBuscarcliente.Text = "Buscar Cliente";
            // 
            // cbxBuscarcliente
            // 
            cbxBuscarcliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBuscarcliente.FormattingEnabled = true;
            cbxBuscarcliente.Items.AddRange(new object[] { "Ingresado", "En proceso", "Terminado" });
            cbxBuscarcliente.Location = new Point(49, 58);
            cbxBuscarcliente.Name = "cbxBuscarcliente";
            cbxBuscarcliente.Size = new Size(146, 23);
            cbxBuscarcliente.TabIndex = 31;
            // 
            // lblTextobuscar
            // 
            lblTextobuscar.AutoSize = true;
            lblTextobuscar.Font = new Font("Trebuchet MS", 8.25F);
            lblTextobuscar.Location = new Point(223, 29);
            lblTextobuscar.Name = "lblTextobuscar";
            lblTextobuscar.Size = new Size(116, 16);
            lblTextobuscar.TabIndex = 32;
            lblTextobuscar.Text = "Buscar Codigo Cliente";
            // 
            // txtNumeropedido
            // 
            txtNumeropedido.Location = new Point(223, 58);
            txtNumeropedido.Name = "txtNumeropedido";
            txtNumeropedido.Size = new Size(182, 23);
            txtNumeropedido.TabIndex = 33;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(255, 211, 182);
            btnBuscar.Font = new Font("Trebuchet MS", 8.25F);
            btnBuscar.Location = new Point(440, 52);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(107, 33);
            btnBuscar.TabIndex = 34;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnVertodo
            // 
            btnVertodo.BackColor = Color.FromArgb(255, 211, 182);
            btnVertodo.Font = new Font("Trebuchet MS", 8.25F);
            btnVertodo.Location = new Point(570, 52);
            btnVertodo.Name = "btnVertodo";
            btnVertodo.Size = new Size(107, 33);
            btnVertodo.TabIndex = 35;
            btnVertodo.Text = "Ver todo";
            btnVertodo.UseVisualStyleBackColor = false;
            btnVertodo.Click += btnVertodo_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(933, 249);
            dataGridView1.TabIndex = 36;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Font = new Font("Trebuchet MS", 8.25F);
            lblResumen.Location = new Point(48, 409);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(123, 16);
            lblResumen.TabIndex = 37;
            lblResumen.Text = "Pedidos encontrados: 0";
            lblResumen.Click += lblResumen_Click;
            // 
            // lblResumen2
            // 
            lblResumen2.AutoSize = true;
            lblResumen2.Font = new Font("Trebuchet MS", 8.25F);
            lblResumen2.Location = new Point(235, 409);
            lblResumen2.Name = "lblResumen2";
            lblResumen2.Size = new Size(127, 16);
            lblResumen2.TabIndex = 38;
            lblResumen2.Text = "Total Ventas Pedidos: $0";
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.FromArgb(255, 182, 200);
            btnAtras.Font = new Font("Trebuchet MS", 8.25F);
            btnAtras.Location = new Point(49, 439);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(107, 33);
            btnAtras.TabIndex = 39;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(1005, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 354);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 233);
            ClientSize = new Size(1293, 534);
            Controls.Add(pictureBox1);
            Controls.Add(btnAtras);
            Controls.Add(lblResumen2);
            Controls.Add(lblResumen);
            Controls.Add(dataGridView1);
            Controls.Add(btnVertodo);
            Controls.Add(btnBuscar);
            Controls.Add(txtNumeropedido);
            Controls.Add(lblTextobuscar);
            Controls.Add(cbxBuscarcliente);
            Controls.Add(lblBuscarcliente);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de informacion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBuscarcliente;
        private ComboBox cbxBuscarcliente;
        private Label lblTextobuscar;
        private TextBox txtNumeropedido;
        private Button btnBuscar;
        private Button btnVertodo;
        private DataGridView dataGridView1;
        private Label lblResumen;
        private Label lblResumen2;
        private Button btnAtras;
        private PictureBox pictureBox1;
    }
}