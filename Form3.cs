using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static panaderia_neko_pan.Registropedidos;

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

            List<Registropedidos.Pedido> pedidos = new List<Registropedidos.Pedido>();

            for (int i = 1; i < registros.Length; i++)
            {
                
                string registro = registros[i];
                
                string[] datos = registro.Split(',');
                if (datos.Length == 15)
                {

                    Registropedidos.Pedido consultaPedido =
                        new Registropedidos.Pedido(
                            int.Parse(datos[0]),
                            datos[1],
                            datos[2],
                            datos[3],
                            int.Parse(datos[4]),
                            datos[5],
                            int.Parse(datos[6]),
                            int.Parse(datos[7]),
                            datos[8],
                            int.Parse(datos[9]),
                            datos[10]
                        );

                    pedidos.Add(consultaPedido);
                }
            } 

            dataGridView1.DataSource = pedidos;
  
        }

    }
}
