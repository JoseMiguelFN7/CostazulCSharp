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

        public static tienda tiendaSeleccionada;
        persona personaActual;
        producto productoSeleccionado;
        int unidades;
        double precioTotal;
        string nombreLogoTienda;

        public formCompra()
        {
            InitializeComponent();
            this.ClientSize = fondo.Size;
        }

        private void formCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!buttonPressed)
            {
                Application.Exit();
            }
        }

        private void formCompra_FormClosed(object sender, FormClosedEventArgs e)
        {
            formTiendas CancelarCompra = new formTiendas();
            CancelarCompra.Visible = true;
        }
        }
    }


