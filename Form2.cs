using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace panaderia_neko_pan
{
    public partial class Registropedidos : Form
    {
        public Registropedidos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtNombrecliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRun_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEstado_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Registropedidos_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            // Creamos el objeto pedido
            Pedido pedido = CrearPedido();

            // Guardar documento
            GuardarPedido(pedido);

            // Mensaje de guardado exitoso
            
            // Borrado de todos los campos
        }

        // Clase utilitaria para validar los inputs
        private bool ValidarDatos()
        {

            // Validar NumeroPedido
            if (!int.TryParse(txtNumeropedido.Text, out int numPedido))
            {
                MessageBox.Show("Error: Ingrese un codigo Numerico Valido!");
                txtNumeropedido.Focus();
                txtNumeropedido.Clear();
                return false;
            }

            // Nombre Cliente
            if (txtNombrecliente.Text.Length <= 1 || txtNombrecliente.Text.Length >= 15) 
            {
                MessageBox.Show("Error: Ingrese un nombre Valido!");
                txtNombrecliente.Focus();
                txtNombrecliente.Clear();
                return false;
            }

            // Run
            if (txtRun.Text.Contains(".") || txtRun.Text.Contains("-")) 
            {
                MessageBox.Show("Error: Ingrese Run sin Puntos ni Digito Verificador");
                txtRun.Focus();
                return false;
            }

            if (txtRun.Text.Length < 7 || txtRun.Text.Length > 8 ||
                !int.TryParse(txtRun.Text, out int num)) 
            {
                MessageBox.Show("Error: Ingrese un Rut Valido");
                txtRun.Focus();
                txtRun.Clear();
                return false;
            }

            // Valida los inputs de: Cantidad, PrecioUnitario y CostoDespacho
            if (!EsNumValido()) return false;

            // Completitud Formulario
            if (!EstaCompletado()) 
            {
                MessageBox.Show("Error: Complete todos los campos del Formulario!");
                return false;
            }


            return true;
        }

        public class Pedido
        {
            public int NumPedido { get; set; }
            public string Fecha { get; set; }
            public string Estado { get; set; }
            public string NombreCliente { get; set; }
            public int RunCliente { get; set; }
            public string TipoProducto { get; set; }
            public int CantidadProducto { get; set; }
            public int PrecioUnitario { get; set; }
            public string TipoEntrega { get; set; }
            public int CostoDespacho { get; set; }
            public string Observacion { get; set; }

            // Costo Items = cantidad items * Precio unitario
            // costo subTotal =  costo Items + costoDespacho
            // costo Iva
            // costo Total = iva + subTotal

            public int CostoItems { get; set; }
            public int CostoSubTotal { get; set; }
            public int CostoIva { get; set; }
            public int CostoTotal { get; set; }

            public Pedido(int numPedido, string fecha, string estado, string nombreCliente, int runCliente, string tipoProducto,
                int cantidadProducto, int precioUnitario, string tipoEntrega, int costoDespacho, string observacion)
            {
                NumPedido = numPedido;
                Fecha = fecha;
                Estado = estado;
                NombreCliente = nombreCliente;
                RunCliente = runCliente;
                TipoProducto = tipoProducto;
                CantidadProducto = cantidadProducto;
                PrecioUnitario = precioUnitario;
                TipoEntrega = tipoEntrega;
                CostoDespacho = costoDespacho;
                Observacion = observacion;

                CostoItems = CalcularCostoItems(cantidadProducto, precioUnitario);
                CostoSubTotal = CalcularSubTotal(CostoItems, costoDespacho);
                CostoIva = CalcularIva(CostoSubTotal);
                CostoTotal = CalcularTotal(CostoSubTotal, CostoIva);
            }

            private int CalcularCostoItems(int cantidadProducto, int precioUnitario)
            {
                return cantidadProducto * precioUnitario;
            }

            private int CalcularSubTotal(int costoItems, int costoDespacho)
            {
                return costoItems + costoDespacho;
            }

            private int CalcularIva(int subTotal)
            {
                return (int)Math.Round(subTotal * 0.19);
            }

            private int CalcularTotal(int costoSubTotal, int iva)
            {
                return costoSubTotal + iva;
            }

        }

        // Crea una lista de objetos tipo textBox para aplicarles las mismas condiciones
        // y asi acceder a sus atributos y metodos
        private bool EsNumValido() 
        {
            TextBox[] componentesNum = new TextBox[]
            {
                txtCantidad, txtPreciounitario,
                txtCostodespacho
            };

            for (int i = 0; i < componentesNum.Length; i++) 
            {
                // Validacion input tipo Int
                /*
                 * Para el output se utiliza Substring de Name, ya que name devuelve el nombre completo
                 * del objeto. Por ende SubString recorta el prefix(txt) del tipo de objeto, mostrando
                 * limpiamente el nombre en pantalla del objeto con el error
                 */
                if (!int.TryParse(componentesNum[i].Text, out int compNumerico))
                {
                    componentesNum[i].Focus();
                    componentesNum[i].Clear();
                    MessageBox.Show($"Error: {componentesNum[i].Name.Substring(3)} debe tener un valor Valido!");

                    return false;
                }

                // Validacion numero positivo mayor a 0
                if (compNumerico <= 0) 
                {
                    if (compNumerico == 0) 
                    {
                        MessageBox.Show($"Error: {componentesNum[i].Name.Substring(3)} no puede ser 0!");
                    }

                    if (compNumerico < 0)
                    {
                        MessageBox.Show($"Error: {componentesNum[i].Name.Substring(3)} debe ser Positivo!");
                    }

                    return false;
                }
            }


            return true;
        }

        // Bool utilitario para ver si estan todos los campos completados
        private bool EstaCompletado() 
        {
            // TODO: Mover esto afuera para mejor accesibilidad
            string[] componentes = new String[] 
            {
                txtNumeropedido.Text, cbxEstado.Text,
                txtNombrecliente.Text, txtRun.Text, 
                cbxTipoEntrega.Text, txtCantidad.Text, 
                txtPreciounitario.Text, txtCostodespacho.Text, 
                cbxTipoproducto.Text
            };

            for (int i = 0; i < componentes.Length; i++) 
            {
                if (componentes[i].Trim() == "") return false;
            }

            return true;
        }

        
        public Pedido CrearPedido() 
        {
            // Mas codigo, pero queda más legible que dejar todo esto en el constructor jeje
            int numPedido = int.Parse(txtNumeropedido.Text);
            int runCliente = int.Parse(txtRun.Text);
            int cantidadProducto = int.Parse(txtCantidad.Text);
            int precioUnitario = int.Parse(txtPreciounitario.Text);
            int costoDespacho = int.Parse(txtCostodespacho.Text);

            string fecha = dateTimePicker1.Text;
            string estado = cbxEstado.Text;
            string nombreCliente = txtNombrecliente.Text;
            string tipoProdcuto = cbxTipoproducto.Text;
            string tipoEntega = cbxTipoEntrega.Text;

            string observacion = txtObservaciones.Text.Replace("\r", " ").Replace("\n", " ");

            Pedido nuevoPedido = new Pedido(
                numPedido, fecha, estado, nombreCliente, runCliente, tipoProdcuto,
                cantidadProducto, precioUnitario, tipoEntega, costoDespacho, observacion
                );

            return nuevoPedido;
        }

        private void GuardarPedido(Pedido pedido) 
        {
            // TODO: Cambiar el nombre del archivo a RegistroPedidos.csv
            string ruta = Application.StartupPath;
            string archivo = Path.Combine(ruta, "Test.txt");

            if (!File.Exists(archivo)) 
            {
                string encabezadoRegistro = "NumPedido,Fecha,Estado,NombreCliente,RunCliente," +
                "TipoProducto,Cantidad,PrecioUnitario,TipoEntrega,CostoDespacho," +
                "Observaciones,CostoIems,SutTotal,Iva,CostoTotal";

                File.WriteAllText(archivo, encabezadoRegistro + Environment.NewLine, Encoding.UTF8);

                // Debug
                MessageBox.Show("Archivo creado en " + ruta);
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
        }
    }
}
