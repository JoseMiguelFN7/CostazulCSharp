using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costazul
{
    public partial class menuEstacionamiento : Form
    {
        bool buttonPressed = false;
        String sectorSeleccionado;
        public static int indexSector;
        public static int numeroSeleccionado;

        public menuEstacionamiento()
        {
            InitializeComponent();
            this.ClientSize = fondo.Size; //Hace que la ventana y el fondo tengan el mismo tamaño.
            sectorPalma.Parent = fondo;
            marcoSPalma.Parent = sectorPalma;
            marcoSPalma.Location = new Point(0, 0);
            sectorMangle.Parent = fondo;
            marcoSMangle.Parent = sectorMangle;
            marcoSMangle.Location = new Point(0, 0);
            sectorSaman.Parent = fondo;
            marcoSSaman.Parent = sectorSaman;
            marcoSSaman.Location = new Point(0, 0);
            sectorRoble.Parent = fondo;
            marcoSRoble.Parent = sectorRoble;
            marcoSRoble.Location = new Point(0, 0);
            sectorGuayacan.Parent = fondo;
            marcoSGuayacan.Parent= sectorGuayacan;
            marcoSGuayacan.Location = new Point(0, 0);
            sectorBambu1.Parent = fondo;
            marcoSB1.Parent = sectorBambu1;
            marcoSB1.Location = new Point(0, 0);
            sectorBambu2.Parent = fondo;
            marcoSB2.Parent = sectorBambu2;
            marcoSB2.Location = new Point(0, 0);

            if (formRegistroUsuarios.esMoto)
            {
                sectorPalma.Visible = true;
                sectorBambu2.Visible = true;
                labelErrorN.Text += "1 y 100.";
                rellenarComboBoxMoto();
            }
            else
            {
                sectorMangle.Visible = true;
                sectorSaman.Visible = true;
                sectorRoble.Visible = true;
                sectorGuayacan.Visible = true;
                sectorBambu1.Visible = true;
                labelErrorN.Text += "1 y 500.";
                rellenarComboBoxCarro();
            }
        }

        private Boolean esNumero(string s)
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

        private void rellenarComboBoxCarro()
        {
            for (int i = 0; i < 500; i++)
            {
                comboBoxNPuestos.Items.Add((i + 1).ToString());
            }
            comboBoxNPuestos.SelectedIndex = 0;
        }

        private void rellenarComboBoxMoto()
        {
            for (int i = 0; i < 100; i++)
            {
                comboBoxNPuestos.Items.Add((i + 1).ToString());
            }
            comboBoxNPuestos.SelectedIndex = 0;
        }

        private void mostrarTooltip(int num)
        {
            marcoTooltipSector.Visible = true;
            tooltipSector.Visible = true;
            switch (num)
            {
                case 0:
                    labelNombreSector.Text = "Sector Palma";
                    break;
                case 1:
                    labelNombreSector.Text = "Sector Mangle";
                    break;
                case 2:
                    labelNombreSector.Text = "Sector Saman";
                    break;
                case 3:
                    labelNombreSector.Text = "Sector Roble";
                    break;
                case 4:
                    labelNombreSector.Text = "Sector Guayacán";
                    break;
                case 5:
                    labelNombreSector.Text = "Sector Bambú 1";
                    break;
                case 6:
                    labelNombreSector.Text = "Sector Bambú 2";
                    break;

            }
        }

        private void sectorPalma_Click(object sender, EventArgs e)
        {
            sectorSeleccionado = "P";
            marcoSPalma.Visible = true;
            marcoSMangle.Visible = false;
            marcoSSaman.Visible = false;
            marcoSRoble.Visible = false;
            marcoSGuayacan.Visible = false;
            marcoSB1.Visible = false;
            marcoSB2.Visible = false;
            PanelSSeleccionada.Visible = true;
            labelSectorSeleccionado.Text = "Sector Palma seleccionado";
            marcoSectorSeleccionado.Visible = true;
        }

        private void sectorMangle_Click(object sender, EventArgs e)
        {
            sectorSeleccionado = "M";
            marcoSPalma.Visible = false;
            marcoSMangle.Visible = true;
            marcoSSaman.Visible = false;
            marcoSRoble.Visible = false;
            marcoSGuayacan.Visible = false;
            marcoSB1.Visible = false;
            marcoSB2.Visible = false;
            PanelSSeleccionada.Visible = true;
            labelSectorSeleccionado.Text = "Sector Mangle seleccionado";
        }

        private void sectorSaman_Click(object sender, EventArgs e)
        {
            sectorSeleccionado = "S";
            marcoSPalma.Visible = false;
            marcoSMangle.Visible = false;
            marcoSSaman.Visible = true;
            marcoSRoble.Visible = false;
            marcoSGuayacan.Visible = false;
            marcoSB1.Visible = false;
            marcoSB2.Visible = false;
            PanelSSeleccionada.Visible = true;
            labelSectorSeleccionado.Text = "Sector Saman seleccionado";
        }

        private void sectorRoble_Click(object sender, EventArgs e)
        {
            sectorSeleccionado = "R";
            marcoSPalma.Visible = false;
            marcoSMangle.Visible = false;
            marcoSSaman.Visible = false;
            marcoSRoble.Visible = true;
            marcoSGuayacan.Visible = false;
            marcoSB1.Visible = false;
            marcoSB2.Visible = false;
            PanelSSeleccionada.Visible = true;
            labelSectorSeleccionado.Text = "Sector Roble seleccionado";
        }

        private void sectorGuayacan_Click(object sender, EventArgs e)
        {
            sectorSeleccionado = "G";
            marcoSPalma.Visible = false;
            marcoSMangle.Visible = false;
            marcoSSaman.Visible = false;
            marcoSRoble.Visible = false;
            marcoSGuayacan.Visible = true;
            marcoSB1.Visible = false;
            marcoSB2.Visible = false;
            PanelSSeleccionada.Visible = true;
            labelSectorSeleccionado.Text = "Sector Guayacán seleccionado";
        }

        private void sectorBambu1_Click(object sender, EventArgs e)
        {
            sectorSeleccionado = "B1";
            marcoSPalma.Visible = false;
            marcoSMangle.Visible = false;
            marcoSSaman.Visible = false;
            marcoSRoble.Visible = false;
            marcoSGuayacan.Visible = false;
            marcoSB1.Visible = true;
            marcoSB2.Visible = false;
            PanelSSeleccionada.Visible = true;
            labelSectorSeleccionado.Text = "Sector Bambú 1 seleccionado";
        }

        private void sectorBambu2_Click(object sender, EventArgs e)
        {
            sectorSeleccionado = "B2";
            marcoSPalma.Visible = false;
            marcoSMangle.Visible = false;
            marcoSSaman.Visible = false;
            marcoSRoble.Visible = false;
            marcoSGuayacan.Visible = false;
            marcoSB1.Visible = false;
            marcoSB2.Visible = true;
            PanelSSeleccionada.Visible = true;
            labelSectorSeleccionado.Text = "Sector Bambú 2 seleccionado";
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            if (sectorSeleccionado != null && esNumero(comboBoxNPuestos.Text))
            {

                if ((formRegistroUsuarios.esMoto && Int32.Parse(comboBoxNPuestos.Text) > 0 && Int32.Parse(comboBoxNPuestos.Text) <= 100) || (!formRegistroUsuarios.esMoto && Int32.Parse(comboBoxNPuestos.Text) > 0 && Int32.Parse(comboBoxNPuestos.Text) <= 500)) //Si es moto solo se permite un numero entre 0 y 100, si es otro vehiculo es entre 0 y 500.
                {
                    PanelMarcoErrorS.Visible = false;
                    PanelErrorS.Visible = false;
                    PanelMarcoErrorN.Visible = false;
                    PanelErrorN.Visible = false;
                    numeroSeleccionado = Int32.Parse(comboBoxNPuestos.Text);
                    switch (sectorSeleccionado)
                    {
                        case "P":
                            indexSector = 0;
                            break;
                        case "M":
                            indexSector = 0;
                            break;
                        case "S":
                            indexSector = 1;
                            break;
                        case "R":
                            indexSector = 2;
                            break;
                        case "G":
                            indexSector = 3;
                            break;
                        case "B1":
                            indexSector = 4;
                            break;
                        case "B2":
                            indexSector = 1;
                            break;
                    }

                    if (formRegistroUsuarios.esMoto) 
                    {
                        if (!bienvenido.sectoresMotos[indexSector, numeroSeleccionado - 1].getOcupantes().puestoOcupado(formRegistroUsuarios.usuariosEnSesion.verTope()))
                        {
                            if (formRegistroUsuarios.numUsuariosEnSesion == 1)
                            {
                                bienvenido.sectoresMotos[indexSector, numeroSeleccionado - 1].getOcupantes().agregarVehiculoAlFinal(formRegistroUsuarios.usuariosEnSesion.verTope().getVehiculo());
                            }
                            marcoPanelPregunta.Visible = true;
                        }
                        else
                        {
                            PanelMarcoPOcupado.Visible = true;
                            PanelPOcupado.Visible = true;
                            labelPOcupado.Visible = true;
                            Thread thread = new Thread(new ThreadStart(sleep));
                            thread.Start();
                            thread.Join();
                            PanelMarcoPOcupado.Visible = false;
                            PanelPOcupado.Visible = false;
                            labelPOcupado.Visible = false;
                        }
                        
                    }
                    else
                    {
                        if (!bienvenido.sectoresCarros[indexSector, numeroSeleccionado - 1].getOcupantes().puestoOcupado(formRegistroUsuarios.usuariosEnSesion.verTope()))
                        {
                            if (formRegistroUsuarios.numUsuariosEnSesion == 1)
                            {
                                bienvenido.sectoresCarros[indexSector, numeroSeleccionado - 1].getOcupantes().agregarVehiculoAlFinal(formRegistroUsuarios.usuariosEnSesion.verTope().getVehiculo());
                            }
                            marcoPanelPregunta.Visible = true;
                        }
                        else
                        {
                            PanelMarcoPOcupado.Visible = true;
                            PanelPOcupado.Visible = true;
                            labelPOcupado.Visible = true;
                            Thread thread = new Thread(new ThreadStart(sleep));
                            thread.Start();
                            thread.Join();
                            PanelMarcoPOcupado.Visible = false;
                            PanelPOcupado.Visible = false;
                            labelPOcupado.Visible = false;
                        }
                    }
                }
                else
                {
                    PanelErrorN.Visible = true;
                    PanelMarcoErrorN.Visible = true;
                }
            }
            else
            {
                if (sectorSeleccionado == null)
                {
                    PanelMarcoErrorS.Visible = true;
                    PanelErrorS.Visible = true;
                }
                else
                {
                    PanelMarcoErrorS.Visible = false;
                    PanelErrorS.Visible = false;
                }

                if (!esNumero(comboBoxNPuestos.Text))
                {
                    PanelMarcoErrorN.Visible = true;
                    PanelErrorN.Visible = true;
                }
                else
                {
                    PanelMarcoErrorN.Visible = false;
                    PanelErrorN.Visible = false;
                }
            }
        }

        private void sleep()
        {
            Thread.Sleep(2500);
        }

        private void sectorPalma_MouseEnter(object sender, EventArgs e)
        {
            mostrarTooltip(0);
        }

        private void sectorMangle_MouseEnter(object sender, EventArgs e)
        {
            mostrarTooltip(1);
        }

        private void sectorSaman_MouseEnter(object sender, EventArgs e)
        {
            mostrarTooltip(2);
        }

        private void sectorRoble_MouseEnter(object sender, EventArgs e)
        {
            mostrarTooltip(3);
        }

        private void sectorGuayacan_MouseEnter(object sender, EventArgs e)
        {
            mostrarTooltip(4);
        }

        private void sectorBambu1_MouseEnter(object sender, EventArgs e)
        {
            mostrarTooltip(5);
        }

        private void sectorBambu2_MouseEnter(object sender, EventArgs e)
        {
            mostrarTooltip(6);
        }

        private void sectorPalma_MouseLeave(object sender, EventArgs e)
        {
            tooltipSector.Visible = false;
            marcoTooltipSector.Visible = false;
        }

        private void sectorMangle_MouseLeave(object sender, EventArgs e)
        {
            tooltipSector.Visible = false;
            marcoTooltipSector.Visible = false;
        }

        private void sectorSaman_MouseLeave(object sender, EventArgs e)
        {
            tooltipSector.Visible = false;
            marcoTooltipSector.Visible = false;
        }

        private void sectorRoble_MouseLeave(object sender, EventArgs e)
        {
            tooltipSector.Visible = false;
            marcoTooltipSector.Visible = false;
        }

        private void sectorGuayacan_MouseLeave(object sender, EventArgs e)
        {
            tooltipSector.Visible = false;
            marcoTooltipSector.Visible = false;
        }

        private void sectorBambu1_MouseLeave(object sender, EventArgs e)
        {
            tooltipSector.Visible = false;
            marcoTooltipSector.Visible = false;
        }

        private void sectorBambu2_MouseLeave(object sender, EventArgs e)
        {
            tooltipSector.Visible = false;
            marcoTooltipSector.Visible = false;
        }

        private void menuEstacionamiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!buttonPressed)
            {
                Application.Exit();
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
            if (formRegistroUsuarios.numUsuariosEnSesion == 1)
            {
                bienvenido.personas.agregarPersonaAlFinal(formRegistroUsuarios.usuariosEnSesion.sacarPersonaDePila());
                bienvenido b = new bienvenido();
                formRegistroUsuarios.puedeVehiculo = true;
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