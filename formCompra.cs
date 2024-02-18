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
    }
}
