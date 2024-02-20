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
    public partial class formEditarUsuario : Form
    {
        public formEditarUsuario()
        {
            InitializeComponent();
            this.ClientSize = fondo.Size;
            labelNombre.Parent = fondo;
            labelApellido.Parent = fondo;
            comboBoxTDoc.SelectedIndex = 0;
            panelOpcionesEdicion.Parent = fondo;
        }

        private void radioButtonNA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNA.Checked)
            {
                labelNombre.Visible = true;
                textBoxNombreCI.Visible = true;
                labelApellido.Visible = true;
                textBoxApellido.Visible = true;
                comboBoxTDoc.Visible = false;
                buttonBuscar.Visible = true;
            }
        }

        private void radioButtonCI_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonCI.Checked)
            {
                textBoxNombreCI.Visible = true;
                comboBoxTDoc.Visible = true;
                labelNombre.Visible = false;
                labelApellido.Visible = false;
                textBoxApellido.Visible = false;
                buttonBuscar.Visible = true;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if(radioButtonNA.Checked)
            {
                //BUSCAR POR NOMBRE Y APELLIDO
            }
            else
            {
                //BUSCAR POR CEDULA
            }
        }
    }
}
