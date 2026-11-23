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
            lblNumeropedido.Location = new Point(51, 33);
            lblNumeropedido.Name = "lblNumeropedido";
            lblNumeropedido.Size = new Size(107, 15);
            lblNumeropedido.TabIndex = 1;
            lblNumeropedido.Text = "Numero de pedido";
            // 
            // txtNumeropedido
            // 
            txtNumeropedido.Location = new Point(51, 60);
            txtNumeropedido.Name = "txtNumeropedido";
            txtNumeropedido.Size = new Size(182, 23);
            txtNumeropedido.TabIndex = 2;
            txtNumeropedido.TextChanged += txtNumeropedido_TextChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(250, 33);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(489, 33);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 5;
            lblEstado.Text = "Estado";
            // 
            // txtNombrecliente
            // 
            txtNombrecliente.Location = new Point(51, 137);
            txtNombrecliente.Name = "txtNombrecliente";
            txtNombrecliente.Size = new Size(255, 23);
            txtNombrecliente.TabIndex = 8;
            txtNombrecliente.TextChanged += txtNombrecliente_TextChanged;
            // 
            // lblNombrecliente
            // 
            lblNombrecliente.AutoSize = true;
            lblNombrecliente.Location = new Point(51, 110);
            lblNombrecliente.Name = "lblNombrecliente";
            lblNombrecliente.Size = new Size(108, 15);
            lblNombrecliente.TabIndex = 7;
            lblNombrecliente.Text = "Nombre del cliente";
            // 
            // txtRun
            // 
            txtRun.Location = new Point(335, 138);
            txtRun.Name = "txtRun";
            txtRun.Size = new Size(216, 23);
            txtRun.TabIndex = 10;
            txtRun.TextChanged += txtRun_TextChanged;
            // 
            // lblRun
            // 
            lblRun.AutoSize = true;
            lblRun.Location = new Point(335, 111);
            lblRun.Name = "lblRun";
            lblRun.Size = new Size(28, 15);
            lblRun.TabIndex = 9;
            lblRun.Text = "Run";
            // 
            // lblTipoproducto
            // 
            lblTipoproducto.AutoSize = true;
            lblTipoproducto.Location = new Point(51, 180);
            lblTipoproducto.Name = "lblTipoproducto";
            lblTipoproducto.Size = new Size(99, 15);
            lblTipoproducto.TabIndex = 13;
            lblTipoproducto.Text = "Tipo de producto";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(51, 274);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(255, 23);
            txtCantidad.TabIndex = 16;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(51, 247);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 15;
            lblCantidad.Text = "Cantidad";
            // 
            // txtPreciounitario
            // 
            txtPreciounitario.Location = new Point(335, 274);
            txtPreciounitario.Name = "txtPreciounitario";
            txtPreciounitario.Size = new Size(216, 23);
            txtPreciounitario.TabIndex = 18;
            // 
            // lblPreciounitario
            // 
            lblPreciounitario.AutoSize = true;
            lblPreciounitario.Location = new Point(335, 247);
            lblPreciounitario.Name = "lblPreciounitario";
            lblPreciounitario.Size = new Size(85, 15);
            lblPreciounitario.TabIndex = 17;
            lblPreciounitario.Text = "Precio Unitario";
            // 
            // lblTipoentrega
            // 
            lblTipoentrega.AutoSize = true;
            lblTipoentrega.Location = new Point(51, 317);
            lblTipoentrega.Name = "lblTipoentrega";
            lblTipoentrega.Size = new Size(90, 15);
            lblTipoentrega.TabIndex = 19;
            lblTipoentrega.Text = "Tipo de entrega";
            // 
            // txtCostodespacho
            // 
            txtCostodespacho.Location = new Point(335, 344);
            txtCostodespacho.Name = "txtCostodespacho";
            txtCostodespacho.Size = new Size(216, 23);
            txtCostodespacho.TabIndex = 22;
            // 
            // lblCostodespacho
            // 
            lblCostodespacho.AutoSize = true;
            lblCostodespacho.Location = new Point(335, 317);
            lblCostodespacho.Name = "lblCostodespacho";
            lblCostodespacho.Size = new Size(108, 15);
            lblCostodespacho.TabIndex = 21;
            lblCostodespacho.Text = "Costo de despacho";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(51, 418);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(500, 49);
            txtObservaciones.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 391);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 23;
            label1.Text = "Observaciones";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(589, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 262);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ImeMode = ImeMode.Off;
            dateTimePicker1.Location = new Point(250, 60);
            dateTimePicker1.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2026, 11, 17, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(216, 23);
            dateTimePicker1.TabIndex = 26;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(603, 503);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(107, 33);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(52, 503);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(107, 33);
            btnAtras.TabIndex = 28;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // cbxTipoproducto
            // 
            cbxTipoproducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoproducto.FormattingEnabled = true;
            cbxTipoproducto.Items.AddRange(new object[] { "Pan hallulla", "Pan marraqueta", "Pan dobladitas", "Pan Molde", "Berlin", "Pastel de hoja", "Torta amor", "Torta kawai" });
            cbxTipoproducto.Location = new Point(51, 207);
            cbxTipoproducto.Name = "cbxTipoproducto";
            cbxTipoproducto.Size = new Size(255, 23);
            cbxTipoproducto.TabIndex = 29;
            // 
            // cbxEstado
            // 
            cbxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "Ingresado", "En proceso", "Terminado" });
            cbxEstado.Location = new Point(489, 60);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(216, 23);
            cbxEstado.TabIndex = 30;
            // 
            // cbxTipoEntrega
            // 
            cbxTipoEntrega.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoEntrega.FormattingEnabled = true;
            cbxTipoEntrega.Items.AddRange(new object[] { "Retiro en Tienda", "Despacho a Domicilio" });
            cbxTipoEntrega.Location = new Point(52, 344);
            cbxTipoEntrega.Name = "cbxTipoEntrega";
            cbxTipoEntrega.Size = new Size(254, 23);
            cbxTipoEntrega.TabIndex = 31;
            // 
            // Registropedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 561);
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