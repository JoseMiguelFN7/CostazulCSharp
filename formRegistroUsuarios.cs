using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Costazul
{
    public partial class formRegistroUsuarios : Form
    {
        bool buttonPressed = false;
        bool puedeVehiculo = true;
        pila usuariosEnSesion = new pila();
        int numUsuariosEnSesion = 0;
        static vehiculo vehiculoActual = null;
        static persona usuarioActual;

        public formRegistroUsuarios()
        {
            InitializeComponent();
            this.ClientSize = fondo.Size;

            LabelPrimerNombre.Parent = fondo;
            LabelApellido.Parent = fondo;
            LabelDocumento.Parent = fondo;
            IndiqueHoraDeSalida.Parent = fondo;
            checkBoxPVehiculo.Parent = fondo;
            labelTVehiculo.Parent = fondo;
            labelCAcomp.Parent = fondo;
            labelMVehiculo.Parent = fondo;
            labelCVehiculo.Parent= fondo;
            labelPVehiculo.Parent = fondo;

            comboBoxTDocumento.SelectedIndex = 0;
            comboBoxTVehiculo.SelectedIndex = 0;
            comboBoxMarca.SelectedIndex = 0;
            comboBoxColor.SelectedIndex = 0;

            if (bienvenido.dia.Equals("Domingo"))
            {
                for (int i = bienvenido.hora; i <= 20; i++)
                {
                    comboBoxHora.Items.Add(i.ToString());
                }
            }
            else
            {
                for (int i = bienvenido.hora; i <= 21; i++)
                {
                    comboBoxHora.Items.Add(i.ToString());
                }
            }
            comboBoxHora.SelectedIndex = 0;
        }

        private bool esNumero(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return false;
            }

            byte[] codAscii = ASCIIEncoding.ASCII.GetBytes(s);
            for (int i = 0; i < s.Length; i++)
            {
                if (codAscii[i] < 48 || codAscii[i] > 57)
                {
                    return false;
                }
            }

            return true;
        }

        private bool esMinus(char c)
        {
            byte codAscii = (byte)c;
            if (!(codAscii >= 97 && codAscii <= 122))
            {
                return false;
            }
            return true;
        }

        private bool esMayus(char c)
        {
            byte codAscii = (byte)c;
            if (!(codAscii >= 65 && codAscii <= 90))
            {
                return false;
            }
            return true;
        }

        private bool esLetra(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return false;
            }
            
            for (int i = 0; i < s.Length; i++)
            {
                if (!(esMinus(s[i]) || esMayus(s[i])))
                {
                    return false;
                }
            }
            return true;
        }

        private bool placaValida(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return false;
            }

            for (int i = 0;i < s.Length;i++)
            {
                if (!(esMayus(s[i]) || esNumero(s[i].ToString())))
                {
                    return false;
                }
            }
            return true;
        }

        private void formRegistroUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!buttonPressed)
            {
                Application.Exit();
            }
        }

        private void comboBoxHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMinuto.Items.Clear();
            if (Int32.Parse(comboBoxHora.SelectedItem.ToString()) == bienvenido.hora)
            {
                for (int i = bienvenido.minuto; i < 60; i++)
                {
                    if (i < 10)
                    {
                        comboBoxMinuto.Items.Add("0" + i.ToString());
                    }
                    else
                    {
                        comboBoxMinuto.Items.Add(i.ToString());
                    }
                }
            }
            else
            {
                if (comboBoxHora.SelectedIndex == comboBoxHora.Items.Count - 1)
                {
                    comboBoxMinuto.Items.Add("00");
                }
                else
                {
                    for (int i = 0; i < 60; i++)
                    {
                        if (i < 10)
                        {
                            comboBoxMinuto.Items.Add("0" + i.ToString());
                        }
                        else
                        {
                            comboBoxMinuto.Items.Add(i.ToString());
                        }
                    }
                }
            }
            comboBoxMinuto.SelectedIndex = 0;
        }

        private void comboBoxTVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNAcomp.Items.Clear();
            int nMaxAcomp = 0;
            switch (comboBoxTVehiculo.SelectedIndex)
            {
                case 0:
                    nMaxAcomp = 9;
                    break;
                case 1:
                    nMaxAcomp = 7;
                    break;
                case 2:
                    nMaxAcomp = 4;
                    break;
                case 3:
                    nMaxAcomp = 2;
                    break;
                case 4:
                    nMaxAcomp = 6;
                    break;
            }
            for (int i = 0;i <= nMaxAcomp;i++)
            {
                comboBoxNAcomp.Items.Add(i.ToString());
            }
            comboBoxNAcomp.SelectedIndex = 0;
        }

        private void checkBoxPVehiculo_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxPVehiculo.Checked)
            {
                labelTVehiculo.Visible = true;
                comboBoxTVehiculo.Visible = true;

                labelCVehiculo.Visible = true;
                comboBoxColor.Visible = true;

                labelCAcomp.Visible = true;
                comboBoxNAcomp.Visible = true;

                labelMVehiculo.Visible=true;
                comboBoxMarca.Visible = true;


                labelPVehiculo.Visible = true;
                textBoxPlaca.Visible = true;
            }
            else
            {
                labelTVehiculo.Visible = false;
                comboBoxTVehiculo.Visible = false;

                labelCVehiculo.Visible = false;
                comboBoxColor.Visible = false;

                labelCAcomp.Visible = false;
                comboBoxNAcomp.Visible = false;

                labelMVehiculo.Visible = false;
                comboBoxMarca.Visible = false;

                labelPVehiculo.Visible = false;
                textBoxPlaca.Visible = false;
            }
        }

        private void ButtonValidacionRegistro_Click(object sender, EventArgs e)
        {
            if(!esLetra(textBoxNombre.Text))
            {
                labelErrorPrimerNombre.Visible = true;
            }
            else
            {
                labelErrorPrimerNombre.Visible = false;
            }

            if (true)
            {
                //usuariosEnSesion.agregarPersonaEnLaPila(new persona())
            }
        }
    }
}
