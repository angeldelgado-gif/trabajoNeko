using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace panaderia_neko_pan
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPedido();
        }

        private void btnVertodo_Click(object sender, EventArgs e)
        {

        }

        // Busca el pedido 
        private void BuscarPedido() 
        {
            string ruta = Application.StartupPath;
            string archivo = Path.Combine(ruta, "RegistroPedidos.csv");

            if (!File.Exists(archivo)) 
            {
                MessageBox.Show("Error: Aun no existe un registro");
                return;
            }

            string[] registros = File.ReadAllLines(archivo);
            StringBuilder resultado = new StringBuilder();

            foreach (string registro in registros)
            {
                string[] datos = registro.Split(',');
                if (datos.Length == 15)
                {
                    resultado.AppendLine("Numero Pedido: " + datos[0]);
                    resultado.AppendLine("Fecha: " + datos[1]);
                    resultado.AppendLine("Estado: " + datos[2]);
                    resultado.AppendLine("Nombre Cliente: " + datos[3]);
                    resultado.AppendLine("Run Cliente: " + datos[4]);
                    resultado.AppendLine("Tipo Producto: " + datos[5]);
                    resultado.AppendLine("Cantidad Producto: " + datos[6]);
                    resultado.AppendLine("Precio unitario: " + datos[7]);
                    resultado.AppendLine("Tipo de entrega: " + datos[8]);
                    resultado.AppendLine("Costo de despacho: " + datos[9]);
                    resultado.AppendLine("Observacion: " + datos[10]);
                    resultado.AppendLine("Costo items: " + datos[11]);
                    resultado.AppendLine("Costo subtotal: " + datos[12]);
                    resultado.AppendLine("Costo IVA: " + datos[13]);
                    resultado.AppendLine("Costo Total: " + datos[14]);



                    resultado.AppendLine("------------------------");
                }
            } // Mostrar los registros
            MessageBox.Show(resultado.Length > 0 ? resultado.ToString() : "No existen registros para mostrar.", "Personas registradas");
            }
 
    }
}
