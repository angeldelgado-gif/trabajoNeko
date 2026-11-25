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
            lblBuscarcliente = new Label();
            cbxBuscarcliente = new ComboBox();
            lblTextobuscar = new Label();
            txtNumeropedido = new TextBox();
            btnBuscar = new Button();
            btnVertodo = new Button();
            dataGridView1 = new DataGridView();
            lblResumen = new Label();
            label1 = new Label();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblBuscarcliente
            // 
            lblBuscarcliente.AutoSize = true;
            lblBuscarcliente.Location = new Point(49, 29);
            lblBuscarcliente.Name = "lblBuscarcliente";
            lblBuscarcliente.Size = new Size(82, 15);
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
            lblTextobuscar.Location = new Point(223, 29);
            lblTextobuscar.Name = "lblTextobuscar";
            lblTextobuscar.Size = new Size(124, 15);
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
            btnBuscar.Location = new Point(440, 52);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(107, 33);
            btnBuscar.TabIndex = 34;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnVertodo
            // 
            btnVertodo.Location = new Point(570, 52);
            btnVertodo.Name = "btnVertodo";
            btnVertodo.Size = new Size(107, 33);
            btnVertodo.TabIndex = 35;
            btnVertodo.Text = "Ver todo";
            btnVertodo.UseVisualStyleBackColor = true;
            btnVertodo.Click += btnVertodo_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(628, 150);
            dataGridView1.TabIndex = 36;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(49, 309);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(130, 15);
            lblResumen.TabIndex = 37;
            lblResumen.Text = "Pedidos encontrados: 0";
            lblResumen.Click += lblResumen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 309);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 38;
            label1.Text = "Total encontrado: $0";
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(49, 379);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(107, 33);
            btnAtras.TabIndex = 39;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 450);
            Controls.Add(btnAtras);
            Controls.Add(label1);
            Controls.Add(lblResumen);
            Controls.Add(dataGridView1);
            Controls.Add(btnVertodo);
            Controls.Add(btnBuscar);
            Controls.Add(txtNumeropedido);
            Controls.Add(lblTextobuscar);
            Controls.Add(cbxBuscarcliente);
            Controls.Add(lblBuscarcliente);
            Name = "Form3";
            Text = "Consulta de informacion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label1;
        private Button btnAtras;
    }
}