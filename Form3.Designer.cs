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
            dataPedidos = new DataGridView();
            lblResumen = new Label();
            lblTotal = new Label();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)dataPedidos).BeginInit();
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
            lblTextobuscar.Size = new Size(82, 15);
            lblTextobuscar.TabIndex = 32;
            lblTextobuscar.Text = "Texto a buscar";
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
            // 
            // btnVertodo
            // 
            btnVertodo.Location = new Point(570, 52);
            btnVertodo.Name = "btnVertodo";
            btnVertodo.Size = new Size(107, 33);
            btnVertodo.TabIndex = 35;
            btnVertodo.Text = "Ver todo";
            btnVertodo.UseVisualStyleBackColor = true;
            // 
            // dataPedidos
            // 
            dataPedidos.AllowUserToAddRows = false;
            dataPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPedidos.Location = new Point(49, 123);
            dataPedidos.Name = "dataPedidos";
            dataPedidos.Size = new Size(628, 150);
            dataPedidos.TabIndex = 36;
            dataPedidos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(49, 309);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(130, 15);
            lblResumen.TabIndex = 37;
            lblResumen.Text = "Pedidos encontrados: 0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(236, 309);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(115, 15);
            lblTotal.TabIndex = 38;
            lblTotal.Text = "Total encontrado: $0";
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
            ClientSize = new Size(718, 450);
            Controls.Add(btnAtras);
            Controls.Add(lblTotal);
            Controls.Add(lblResumen);
            Controls.Add(dataPedidos);
            Controls.Add(btnVertodo);
            Controls.Add(btnBuscar);
            Controls.Add(txtNumeropedido);
            Controls.Add(lblTextobuscar);
            Controls.Add(cbxBuscarcliente);
            Controls.Add(lblBuscarcliente);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de informacion";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataPedidos).EndInit();
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
        private DataGridView dataPedidos;
        private Label lblResumen;
        private Label lblTotal;
        private Button btnAtras;
    }
}