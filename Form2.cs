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

            // Debug
            MessageBox.Show("Exitooo!");

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
        }
    }
}
