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

        tienda tiendaSeleccionada = formTiendas.tiendaSeleccionada;
        producto productoSeleccionado;
        int unidades = 0;
        double precioTotal;
        Image LogoTienda = formTiendas.logotienda;
        string tipoCompra = null;
        string metodoPago = null;
        compra compraRealizada = null;

        public formCompra()
        {
            InitializeComponent();
            this.ClientSize = fondo.Size;
            labelNameTienda.Text = tiendaSeleccionada.getNombre();
            tiendaSeleccionada.getProductos().llenarComboBoxProductos(comboBoxProductos);
            comboBoxProductos.SelectedIndex = 0;
            BoxLogo2.Image = LogoTienda;
            groupBoxTCompra.Parent = fondo;
            labelPdto.Parent = fondo;
            labelPrecio.Parent = fondo;
            labelPTotal.Parent = fondo;
            labelTipoCompra.Parent = fondo;
            labelAviso.Parent = fondo;
            unidades = (int)numericUpDownUnidades.Value;
            precioTotal = productoSeleccionado.getPrecio() * unidades;
            labelErrorMP.Parent = fondo;
            labelErrorTC.Parent = fondo;
        }

        private void formCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!buttonPressed)
            {
                formTiendas ft = new formTiendas();
                ft.Show();
            }
        }

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            productoSeleccionado = tiendaSeleccionada.getProductos().buscarProducto(comboBoxProductos.SelectedItem.ToString());
            textBox1.Text = productoSeleccionado.getDescripcion();
            unidades = (int)numericUpDownUnidades.Value;
            precioTotal = unidades * productoSeleccionado.getPrecio();
            labelPrecio.Text = "Precio: " + productoSeleccionado.getPrecio() + "$";
            labelPTotal.Text = "Total a pagar: " + String.Format("{0:0.00}", precioTotal) + "$";
        }

        private void radioButtonPagoMovil_CheckedChanged(object sender, EventArgs e)
        {
            metodoPago = "Pago Móvil";
        }

        private void radioButtonZelle_CheckedChanged(object sender, EventArgs e)
        {
            metodoPago = "Zelle";
        }

        private void radioButtonTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            metodoPago = "Transferencia";
        }

        private void radioButtonEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            metodoPago = "Efectivo";
        }

        private void radioButtonTDD_CheckedChanged(object sender, EventArgs e)
        {
            metodoPago = "TDD";
        }

        private void radioButtonTDC_CheckedChanged(object sender, EventArgs e)
        {
            metodoPago = "TDC";
        }

        private void radioButtonOnline_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOnline.Checked)
            {
                marcoMPOnline.Visible = true;
                marcoMPPresencial.Visible = false;
                tipoCompra = "Online";
                metodoPago = null;
                radioButtonEfectivo.Checked = false;
                radioButtonTDD.Checked = false;
                radioButtonTDC.Checked = false;
            }
        }

        private void radioButtonPresencial_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPresencial.Checked)
            {
                marcoMPPresencial.Visible = true;
                marcoMPOnline.Visible = false;
                tipoCompra = "Presencial";
                metodoPago = null;
                radioButtonPagoMovil.Checked = false;
                radioButtonTransferencia.Checked = false;
                radioButtonZelle.Checked = false;
            }
        }

        private void buttonCompra_Click(object sender, EventArgs e)
        {
            if (metodoPago != null && tipoCompra != null)
            {
                labelErrorMP.Visible = false;
                labelErrorTC.Visible = false;
                compraRealizada = new compra(formRegistroUsuarios.usuariosEnSesion.verTope(), tiendaSeleccionada, productoSeleccionado, unidades, precioTotal, tipoCompra, metodoPago);
                formRegistroUsuarios.usuariosEnSesion.verTope().getCompras().agregarCompraAlFinal(compraRealizada);
                marcoPregunta.Visible = true;
            }
            else
            {
                if (metodoPago == null)
                {
                    labelErrorMP.Visible = true;
                }
                else
                {
                    labelErrorMP.Visible = false;
                }

                if (tipoCompra == null)
                {
                    labelErrorTC.Visible = true;
                }
                else
                {
                    labelErrorTC.Visible = false;
                }
            }
        }

        private void numericUpDownUnidades_ValueChanged(object sender, EventArgs e)
        {
            unidades = (int)numericUpDownUnidades.Value;
            precioTotal = unidades * productoSeleccionado.getPrecio();
            labelPTotal.Text = "Total a pagar: " + String.Format("{0:0.00}", precioTotal) + "$";
        }

        private void buttonOtraCompraSi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOtraCompraNo_Click(object sender, EventArgs e)
        {
            buttonPressed = true;
            if (formRegistroUsuarios.numUsuariosEnSesion > formRegistroUsuarios.usuariosEnSesion.getTamanio())
            {
                formRegistroUsuarios ru = new formRegistroUsuarios();
                ru.Show();
                this.Close();
            }
            else
            {
                while (!formRegistroUsuarios.usuariosEnSesion.esVacia())
                {
                    bienvenido.personas.agregarPersonaAlFinal(formRegistroUsuarios.usuariosEnSesion.sacarPersonaDePila());
                }
                bienvenido b = new bienvenido();
                b.Show();
                this.Close();
            }
        }
    }
}
    


