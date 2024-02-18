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
        static pEstacionamiento puestoSeleccionado;
        String sectorSeleccionado;
        int indexSector;
        bool hizoSeleccion;
        static bool esMoto; //esta variable debe obtenerse del form de datos usuarios.
        static persona usuarioActual; //obtener variable con usuario actual del form de datos usuarios
        public menuEstacionamiento()
        {
            esMoto = false;
            hizoSeleccion = false;
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

            if (esMoto)
            {
                sectorPalma.Visible = true;
                sectorBambu2.Visible = true;
                labelErrorN.Text += "1 y 100.";
            }
            else
            {
                sectorMangle.Visible = true;
                sectorSaman.Visible = true;
                sectorRoble.Visible = true;
                sectorGuayacan.Visible = true;
                sectorBambu1.Visible = true;
                labelErrorN.Text += "1 y 500.";
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
            if (!hizoSeleccion)
            {
                for (int i = 0; i < 500; i++)
                {
                    comboBoxNPuestos.Items.Add((i + 1).ToString());
                }
                comboBoxNPuestos.SelectedIndex = 0;
                hizoSeleccion = true;
            }
        }

        private void rellenarComboBoxMoto()
        {
            if (!hizoSeleccion)
            {
                for (int i = 0; i < 100; i++)
                {
                    comboBoxNPuestos.Items.Add((i + 1).ToString());
                }
                comboBoxNPuestos.SelectedIndex = 0;
                hizoSeleccion = true;
            }
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
            rellenarComboBoxMoto();
            sectorSeleccionado = "P";
            marcoSPalma.Visible = true;
            marcoSMangle.Visible = false;
            marcoSSaman.Visible = false;
            marcoSRoble.Visible = false;
            marcoSGuayacan.Visible = false;
            marcoSB1.Visible = false;
            marcoSB2.Visible = false;
            PanelSSeleccionada.Visible = true;
        }

        private void sectorMangle_Click(object sender, EventArgs e)
        {
            rellenarComboBoxCarro();
            sectorSeleccionado = "M";
            marcoSPalma.Visible = false;
            marcoSMangle.Visible = true;
            marcoSSaman.Visible = false;
            marcoSRoble.Visible = false;
            marcoSGuayacan.Visible = false;
            marcoSB1.Visible = false;
            marcoSB2.Visible = false;
            PanelSSeleccionada.Visible = true;
        }

        private void sectorSaman_Click(object sender, EventArgs e)
        {
            rellenarComboBoxCarro();
            sectorSeleccionado = "S";
            marcoSPalma.Visible = false;
            marcoSMangle.Visible = false;
            marcoSSaman.Visible = true;
            marcoSRoble.Visible = false;
            marcoSGuayacan.Visible = false;
            marcoSB1.Visible = false;
            marcoSB2.Visible = false;
            PanelSSeleccionada.Visible = true;
        }

        private void sectorRoble_Click(object sender, EventArgs e)
        {
            rellenarComboBoxCarro();
            sectorSeleccionado = "R";
            marcoSPalma.Visible = false;
            marcoSMangle.Visible = false;
            marcoSSaman.Visible = false;
            marcoSRoble.Visible = true;
            marcoSGuayacan.Visible = false;
            marcoSB1.Visible = false;
            marcoSB2.Visible = false;
            PanelSSeleccionada.Visible = true;
        }

        private void sectorGuayacan_Click(object sender, EventArgs e)
        {
            rellenarComboBoxCarro();
            sectorSeleccionado = "G";
            marcoSPalma.Visible = false;
            marcoSMangle.Visible = false;
            marcoSSaman.Visible = false;
            marcoSRoble.Visible = false;
            marcoSGuayacan.Visible = true;
            marcoSB1.Visible = false;
            marcoSB2.Visible = false;
            PanelSSeleccionada.Visible = true;
        }

        private void sectorBambu1_Click(object sender, EventArgs e)
        {
            rellenarComboBoxCarro();
            sectorSeleccionado = "B1";
            marcoSPalma.Visible = false;
            marcoSMangle.Visible = false;
            marcoSSaman.Visible = false;
            marcoSRoble.Visible = false;
            marcoSGuayacan.Visible = false;
            marcoSB1.Visible = true;
            marcoSB2.Visible = false;
            PanelSSeleccionada.Visible = true;
        }

        private void sectorBambu2_Click(object sender, EventArgs e)
        {
            rellenarComboBoxMoto();
            sectorSeleccionado = "B2";
            marcoSPalma.Visible = false;
            marcoSMangle.Visible = false;
            marcoSSaman.Visible = false;
            marcoSRoble.Visible = false;
            marcoSGuayacan.Visible = false;
            marcoSB1.Visible = false;
            marcoSB2.Visible = true;
            PanelSSeleccionada.Visible = true;
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            if (sectorSeleccionado != null && esNumero(comboBoxNPuestos.Text))
            {

                if ((esMoto && Int32.Parse(comboBoxNPuestos.Text) > 0 && Int32.Parse(comboBoxNPuestos.Text) <= 100) || (!esMoto && Int32.Parse(comboBoxNPuestos.Text) > 0 && Int32.Parse(comboBoxNPuestos.Text) <= 500)) //Si es moto solo se permite un numero entre 0 y 100, si es otro vehiculo es entre 0 y 500.
                {
                    PanelMarcoErrorS.Visible = false;
                    PanelErrorS.Visible = false;
                    PanelMarcoErrorN.Visible = false;
                    PanelErrorN.Visible = false;
                    int numeroSeleccionado = Int32.Parse(comboBoxNPuestos.Text);
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

                    if (esMoto) 
                    {
                        if (!bienvenido.sectoresMotos[indexSector, numeroSeleccionado - 1].getOcupantes().puestoOcupado(usuarioActual))
                        {
                            //puestoSeleccionado = bienvenido.sectoresMotos[indexSector, numeroSeleccionado - 1];
                            //Si numUsuariosSesion=1 meterlo en la lista de ocupantes y actualizar arreglo de motos
                            //agregar persona en tope de pila a lista de ocupantes del puesto
                            //bienvenido.sectoresCarros[indexSector, numeroSeleccionado - 1] = puestoSeleccionado;
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
                        if (true && !bienvenido.sectoresCarros[indexSector, numeroSeleccionado - 1].getOcupantes().puestoOcupado(usuarioActual))
                        {
                            //puestoSeleccionado = bienvenido.sectoresCarros[indexSector, numeroSeleccionado - 1];
                            //Si numUsuariosSesion=1 meterlo en la lista de ocupantes y actualizar arreglo de motos
                            //agregar persona en tope de pila a lista de ocupantes del puesto
                            //bienvenido.sectoresCarros[indexSector, numeroSeleccionado - 1] = puestoSeleccionado;
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
            formRegistroUsuarios ru = new formRegistroUsuarios();
            ru.Show();
            this.Close();
        }
    }
}