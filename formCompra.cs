using Costazul.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costazul
{
    public partial class formCompra : Form
    {
        bool buttonPressed = false;

        static tienda tiendaSeleccionada = formTiendas.tiendaSeleccionada;
        persona personaActual;
        producto productoSeleccionado;
        int unidades;
        double precioTotal;
        string nombreLogoTienda;

        public formCompra()
        {
            InitializeComponent();
            this.ClientSize = fondo.Size;
            labelNameTienda.Text = tiendaSeleccionada.getNombre();
            tiendaSeleccionada.getProductos().llenarComboBoxProductos(comboBox2);
            comboBox2.SelectedIndex = 0;
            BoxLogo2.Image = formTiendas.logotienda;

        }

        private void formCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void formCompra_FormClosed(object sender, FormClosedEventArgs e)
        {
            formTiendas CancelarCompra = new formTiendas();
            CancelarCompra.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            {
                comboBox1.Items.Clear();
                if (radioButton1.Checked)
                {
                    comboBox1.Items.Add("Pago Movil");
                    comboBox1.Items.Add("Zelle");
                    comboBox1.Items.Add("Transferencia");
                    comboBox1.SelectedIndex = 0;
                }
                else if (radioButton2.Checked)
                {
                    comboBox1.Items.Add("Efectivo");
                    comboBox1.Items.Add("TDD");
                    comboBox1.Items.Add("TDC");
                    comboBox1.SelectedIndex = 0;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            productoSeleccionado = tiendaSeleccionada.getProductos().buscarProducto(comboBox2.SelectedItem.ToString());
        }
    }
}
    


