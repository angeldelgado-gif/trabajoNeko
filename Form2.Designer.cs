namespace panaderia_neko_pan
{
    partial class Registropedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registropedidos));
            lblNumeropedido = new Label();
            txtNumeropedido = new TextBox();
            lblFecha = new Label();
            lblEstado = new Label();
            txtNombrecliente = new TextBox();
            lblNombrecliente = new Label();
            txtRun = new TextBox();
            lblRun = new Label();
            lblTipoproducto = new Label();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            txtPreciounitario = new TextBox();
            lblPreciounitario = new Label();
            lblTipoentrega = new Label();
            txtCostodespacho = new TextBox();
            lblCostodespacho = new Label();
            txtObservaciones = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            btnGuardar = new Button();
            btnAtras = new Button();
            cbxTipoproducto = new ComboBox();
            cbxEstado = new ComboBox();
            cbxTipoEntrega = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNumeropedido
            // 
            lblNumeropedido.AutoSize = true;
            lblNumeropedido.Font = new Font("Trebuchet MS", 8.25F);
            lblNumeropedido.Location = new Point(44, 35);
            lblNumeropedido.Name = "lblNumeropedido";
            lblNumeropedido.Size = new Size(96, 16);
            lblNumeropedido.TabIndex = 1;
            lblNumeropedido.Text = "Numero de pedido";
            // 
            // txtNumeropedido
            // 
            txtNumeropedido.Location = new Point(44, 64);
            txtNumeropedido.Name = "txtNumeropedido";
            txtNumeropedido.Size = new Size(157, 20);
            txtNumeropedido.TabIndex = 2;
            txtNumeropedido.TextChanged += txtNumeropedido_TextChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Trebuchet MS", 8.25F);
            lblFecha.Location = new Point(214, 35);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(37, 16);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Trebuchet MS", 8.25F);
            lblEstado.Location = new Point(419, 35);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(41, 16);
            lblEstado.TabIndex = 5;
            lblEstado.Text = "Estado";
            // 
            // txtNombrecliente
            // 
            txtNombrecliente.Location = new Point(44, 146);
            txtNombrecliente.Name = "txtNombrecliente";
            txtNombrecliente.Size = new Size(219, 20);
            txtNombrecliente.TabIndex = 8;
            txtNombrecliente.TextChanged += txtNombrecliente_TextChanged;
            // 
            // lblNombrecliente
            // 
            lblNombrecliente.AutoSize = true;
            lblNombrecliente.Font = new Font("Trebuchet MS", 8.25F);
            lblNombrecliente.Location = new Point(44, 117);
            lblNombrecliente.Name = "lblNombrecliente";
            lblNombrecliente.Size = new Size(99, 16);
            lblNombrecliente.TabIndex = 7;
            lblNombrecliente.Text = "Nombre del cliente";
            // 
            // txtRun
            // 
            txtRun.Location = new Point(287, 147);
            txtRun.Name = "txtRun";
            txtRun.Size = new Size(186, 20);
            txtRun.TabIndex = 10;
            txtRun.TextChanged += txtRun_TextChanged;
            // 
            // lblRun
            // 
            lblRun.AutoSize = true;
            lblRun.Font = new Font("Trebuchet MS", 8.25F);
            lblRun.Location = new Point(287, 118);
            lblRun.Name = "lblRun";
            lblRun.Size = new Size(25, 16);
            lblRun.TabIndex = 9;
            lblRun.Text = "Run";
            // 
            // lblTipoproducto
            // 
            lblTipoproducto.AutoSize = true;
            lblTipoproducto.Font = new Font("Trebuchet MS", 8.25F);
            lblTipoproducto.Location = new Point(44, 192);
            lblTipoproducto.Name = "lblTipoproducto";
            lblTipoproducto.Size = new Size(92, 16);
            lblTipoproducto.TabIndex = 13;
            lblTipoproducto.Text = "Tipo de producto";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(44, 292);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(219, 20);
            txtCantidad.TabIndex = 16;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Trebuchet MS", 8.25F);
            lblCantidad.Location = new Point(44, 263);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(52, 16);
            lblCantidad.TabIndex = 15;
            lblCantidad.Text = "Cantidad";
            // 
            // txtPreciounitario
            // 
            txtPreciounitario.Location = new Point(287, 292);
            txtPreciounitario.Name = "txtPreciounitario";
            txtPreciounitario.Size = new Size(186, 20);
            txtPreciounitario.TabIndex = 18;
            // 
            // lblPreciounitario
            // 
            lblPreciounitario.AutoSize = true;
            lblPreciounitario.Font = new Font("Trebuchet MS", 8.25F);
            lblPreciounitario.Location = new Point(287, 263);
            lblPreciounitario.Name = "lblPreciounitario";
            lblPreciounitario.Size = new Size(82, 16);
            lblPreciounitario.TabIndex = 17;
            lblPreciounitario.Text = "Precio Unitario";
            // 
            // lblTipoentrega
            // 
            lblTipoentrega.AutoSize = true;
            lblTipoentrega.Font = new Font("Trebuchet MS", 8.25F);
            lblTipoentrega.Location = new Point(44, 338);
            lblTipoentrega.Name = "lblTipoentrega";
            lblTipoentrega.Size = new Size(86, 16);
            lblTipoentrega.TabIndex = 19;
            lblTipoentrega.Text = "Tipo de entrega";
            // 
            // txtCostodespacho
            // 
            txtCostodespacho.Location = new Point(287, 367);
            txtCostodespacho.Name = "txtCostodespacho";
            txtCostodespacho.Size = new Size(186, 20);
            txtCostodespacho.TabIndex = 22;
            // 
            // lblCostodespacho
            // 
            lblCostodespacho.AutoSize = true;
            lblCostodespacho.Font = new Font("Trebuchet MS", 8.25F);
            lblCostodespacho.Location = new Point(287, 338);
            lblCostodespacho.Name = "lblCostodespacho";
            lblCostodespacho.Size = new Size(101, 16);
            lblCostodespacho.TabIndex = 21;
            lblCostodespacho.Text = "Costo de despacho";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(44, 446);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(429, 52);
            txtObservaciones.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 8.25F);
            label1.Location = new Point(44, 417);
            label1.Name = "label1";
            label1.Size = new Size(81, 16);
            label1.TabIndex = 23;
            label1.Text = "Observaciones";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(505, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ImeMode = ImeMode.Off;
            dateTimePicker1.Location = new Point(214, 64);
            dateTimePicker1.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2026, 11, 17, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(186, 20);
            dateTimePicker1.TabIndex = 26;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(255, 211, 182);
            btnGuardar.Font = new Font("Trebuchet MS", 8.25F);
            btnGuardar.Location = new Point(517, 537);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(92, 35);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.FromArgb(255, 182, 200);
            btnAtras.Font = new Font("Trebuchet MS", 8.25F);
            btnAtras.Location = new Point(45, 537);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(92, 35);
            btnAtras.TabIndex = 28;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // cbxTipoproducto
            // 
            cbxTipoproducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoproducto.FormattingEnabled = true;
            cbxTipoproducto.Items.AddRange(new object[] { "Pan hallulla", "Pan marraqueta", "Pan dobladitas", "Pan Molde", "Berlin", "Pastel de hoja", "Torta amor", "Torta kawai" });
            cbxTipoproducto.Location = new Point(44, 221);
            cbxTipoproducto.Name = "cbxTipoproducto";
            cbxTipoproducto.Size = new Size(219, 24);
            cbxTipoproducto.TabIndex = 29;
            // 
            // cbxEstado
            // 
            cbxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "Ingresado", "En proceso", "Terminado" });
            cbxEstado.Location = new Point(419, 64);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(186, 24);
            cbxEstado.TabIndex = 30;
            // 
            // cbxTipoEntrega
            // 
            cbxTipoEntrega.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoEntrega.FormattingEnabled = true;
            cbxTipoEntrega.Items.AddRange(new object[] { "Retiro en Tienda", "Despacho a Domicilio" });
            cbxTipoEntrega.Location = new Point(45, 367);
            cbxTipoEntrega.Name = "cbxTipoEntrega";
            cbxTipoEntrega.Size = new Size(218, 24);
            cbxTipoEntrega.TabIndex = 31;
            // 
            // Registropedidos
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 201, 214);
            ClientSize = new Size(705, 598);
            Controls.Add(cbxTipoEntrega);
            Controls.Add(cbxEstado);
            Controls.Add(cbxTipoproducto);
            Controls.Add(btnAtras);
            Controls.Add(btnGuardar);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(txtObservaciones);
            Controls.Add(label1);
            Controls.Add(txtCostodespacho);
            Controls.Add(lblCostodespacho);
            Controls.Add(lblTipoentrega);
            Controls.Add(txtPreciounitario);
            Controls.Add(lblPreciounitario);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(lblTipoproducto);
            Controls.Add(txtRun);
            Controls.Add(lblRun);
            Controls.Add(txtNombrecliente);
            Controls.Add(lblNombrecliente);
            Controls.Add(lblEstado);
            Controls.Add(lblFecha);
            Controls.Add(txtNumeropedido);
            Controls.Add(lblNumeropedido);
            Font = new Font("Trebuchet MS", 8.25F);
            Name = "Registropedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de pedidos";
            Load += Registropedidos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNumeropedido;
        private TextBox txtNumeropedido;
        private Label lblFecha;
        private TextBox txtEstado;
        private Label lblEstado;
        private TextBox txtNombrecliente;
        private Label lblNombrecliente;
        private TextBox txtRun;
        private Label lblRun;
        private Label lblTipoproducto;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private TextBox txtPreciounitario;
        private Label lblPreciounitario;
        private Label lblTipoentrega;
        private TextBox txtCostodespacho;
        private Label lblCostodespacho;
        private TextBox txtObservaciones;
        private Label label1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Button btnGuardar;
        private Button btnAtras;
        private ComboBox cbxTipoproducto;
        private ComboBox cbxEstado;
        private ComboBox cbxTipoEntrega;
    }
}