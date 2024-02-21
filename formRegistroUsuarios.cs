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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Costazul
{
    public partial class formRegistroUsuarios : Form
    {
        bool buttonPressed = false;
        public static bool puedeVehiculo = true;
        public static pila usuariosEnSesion = new pila();
        public static int numUsuariosEnSesion = 0;
        static vehiculo vehiculoActual;
        public static bool esMoto;

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

            labelErrorPrimerNombre.Parent = fondo;
            labelErrorApellido.Parent = fondo;
            labelErrorDocumento.Parent = fondo;
            labelErrorPlaca.Parent = fondo;

            comboBoxTDocumento.SelectedIndex = 0;
            comboBoxTVehiculo.SelectedIndex = 0;
            comboBoxMarca.SelectedIndex = 0;
            comboBoxColor.SelectedIndex = 0;

            if (bienvenido.dia.Equals("Domingo"))
            {
                for (int i = bienvenido.hora; i <= 20; i++)
                {
                    comboBoxHoraDeSalida.Items.Add(i.ToString());
                }
            }
            else
            {
                for (int i = bienvenido.hora; i <= 21; i++)
                {
                    comboBoxHoraDeSalida.Items.Add(i.ToString());
                }
            }
            comboBoxHoraDeSalida.SelectedIndex = 0;

            if(!puedeVehiculo)
            {
                checkBoxPVehiculo.Enabled = false;
            }
        }

        public static bool esNumero(string s)
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

        public static bool esMinus(char c)
        {
            byte codAscii = (byte)c;
            if (!(codAscii >= 97 && codAscii <= 122))
            {
                return false;
            }
            return true;
        }

        public static bool esMayus(char c)
        {
            byte codAscii = (byte)c;
            if (!(codAscii >= 65 && codAscii <= 90))
            {
                return false;
            }
            return true;
        }

        public static bool esLetra(string s)
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

        public static bool placaValida(string s)
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
            comboBoxMinutoDeSalida.Items.Clear();
            if (Int32.Parse(comboBoxHoraDeSalida.SelectedItem.ToString()) == bienvenido.hora)
            {
                for (int i = bienvenido.minuto; i < 60; i++)
                {
                    if (i < 10)
                    {
                        comboBoxMinutoDeSalida.Items.Add("0" + i.ToString());
                    }
                    else
                    {
                        comboBoxMinutoDeSalida.Items.Add(i.ToString());
                    }
                }
            }
            else
            {
                if (comboBoxHoraDeSalida.SelectedIndex == comboBoxHoraDeSalida.Items.Count - 1)
                {
                    comboBoxMinutoDeSalida.Items.Add("00");
                }
                else
                {
                    for (int i = 0; i < 60; i++)
                    {
                        if (i < 10)
                        {
                            comboBoxMinutoDeSalida.Items.Add("0" + i.ToString());
                        }
                        else
                        {
                            comboBoxMinutoDeSalida.Items.Add(i.ToString());
                        }
                    }
                }
            }
            comboBoxMinutoDeSalida.SelectedIndex = 0;
        }


        private void comboBoxTVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTVehiculo.SelectedIndex == 3)
            {
                esMoto = true;
            }
            else
            {
                esMoto = false;
            }
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
                puedeVehiculo = false;
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
                labelErrorPlaca.Visible = false;
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


            if(!esLetra(textBoxApellido.Text))
            {
                labelErrorApellido.Visible = true;
            }
            else
            {
                labelErrorApellido.Visible = false;
            }


            if(!esNumero(textBoxNDocumento.Text))
            {
                labelErrorDocumento.Visible = true;
            }
            else
            {
                labelErrorDocumento.Visible = false;
            }

            bool aceptarPlaca = true;
            if (checkBoxPVehiculo.Checked)
            {
                if (!placaValida(textBoxPlaca.Text))
                {
                    labelErrorPlaca.Visible = true;
                    aceptarPlaca = false;
                }
                else
                {
                    labelErrorPlaca.Visible = false;
                    aceptarPlaca = true;
                }
            }



            if (esLetra(textBoxNombre.Text) && esLetra(textBoxApellido.Text) && esNumero(textBoxNDocumento.Text) && aceptarPlaca)
            {
                usuariosEnSesion.agregarPersonaEnLaPila(new persona(bienvenido.IDPersona, textBoxNombre.Text, textBoxApellido.Text, comboBoxTDocumento.SelectedItem.ToString(), textBoxNDocumento.Text, bienvenido.dia, bienvenido.hora, bienvenido.minuto, Int32.Parse(comboBoxHoraDeSalida.Text), Int32.Parse(comboBoxMinutoDeSalida.Text)));
                bienvenido.IDPersona++;

                if (checkBoxPVehiculo.Checked)
                {
                    vehiculoActual = new vehiculo(bienvenido.IDVehiculo, comboBoxTVehiculo.SelectedItem.ToString(), textBoxPlaca.Text, comboBoxColor.SelectedItem.ToString(), comboBoxMarca.SelectedItem.ToString());
                    bienvenido.IDVehiculo++;
                    numUsuariosEnSesion = Int32.Parse(comboBoxNAcomp.SelectedItem.ToString()) + 1;
                    vehiculoActual.getPasajeros().agregarPersonaAlFinal(usuariosEnSesion.verTope());
                    if (numUsuariosEnSesion > 1)
                    {
                        puedeVehiculo = false;
                    }
                    else
                    {
                        usuariosEnSesion.verTope().setVehiculo(vehiculoActual);
                    }
                    buttonPressed = true;
                    menuEstacionamiento me = new menuEstacionamiento();
                    me.Show();
                    this.Close();
                } 
                else
                {           
                    if(checkBoxPVehiculo.Enabled)
                    {
                        numUsuariosEnSesion = 1;
                        usuariosEnSesion.verTope().setVehiculo(null);
                        marcoPanelPregunta.Visible = true;
                    } 
                    else
                    {
                        vehiculoActual.getPasajeros().agregarPersonaAlFinal(usuariosEnSesion.verTope());
                        if (usuariosEnSesion.getTamanio() < numUsuariosEnSesion)
                        {
                            marcoPanelPregunta.Visible = true;
                        }
                        else
                        {
                            Console.WriteLine(vehiculoActual.getPasajeros().getInicio().getSiguiente().getValorPersona().getNombre());
                            puedeVehiculo = true;
                            usuariosEnSesion.setVehiculoAPila(vehiculoActual);
                            if (esMoto)
                            {
                                bienvenido.sectoresMotos[menuEstacionamiento.indexSector, menuEstacionamiento.numeroSeleccionado].getOcupantes().agregarVehiculoAlFinal(vehiculoActual);
                            }
                            else
                            {
                                bienvenido.sectoresCarros[menuEstacionamiento.indexSector, menuEstacionamiento.numeroSeleccionado].getOcupantes().agregarVehiculoAlFinal(vehiculoActual);
                            }
                            marcoPanelPregunta.Visible = true;
                        }
                    }
                }
            }   
        }

        private void buttonSiCompra_Click(object sender, EventArgs e)
        {
            buttonPressed = true;
            formTiendas ft = new formTiendas();
            ft.Show();
            this.Close();
        }

        private void buttonNoCompra_Click(object sender, EventArgs e)
        {
            buttonPressed = true;
            if (numUsuariosEnSesion == usuariosEnSesion.getTamanio())
            {
                while (!usuariosEnSesion.esVacia())
                {
                    bienvenido.personas.agregarPersonaAlFinal(usuariosEnSesion.sacarPersonaDePila());
                }
                puedeVehiculo = true;
                bienvenido b = new bienvenido();
                b.Show();
                this.Close();
            }
            else
            {
                formRegistroUsuarios ru = new formRegistroUsuarios();
                ru.Show();
                this.Close();
            }
        }
    }
}
