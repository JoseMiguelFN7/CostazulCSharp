using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costazul
{
    public partial class menuEstacionamiento : Form
    {
        static pEstacionamiento puestoSeleccionado = null;
        static String sectorSeleccionado = null;
        static Boolean hizoSeleccion;
        static Boolean esMoto; //esta variable debe obtenerse del form de datos usuarios.
        public menuEstacionamiento()
        {
            esMoto = true;
            hizoSeleccion = false;
            InitializeComponent();
            this.ClientSize = fondo.Size; //Hace que la ventana y el fondo tengan el mismo tamaño.
            sectorPalma.Parent = fondo;
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

        private void sectorPalma_Click(object sender, EventArgs e)
        {
            rellenarComboBoxMoto();
            sectorSeleccionado = "P";
        }

        private void sectorMangle_Click(object sender, EventArgs e)
        {
            rellenarComboBoxCarro();
            sectorSeleccionado = "M";
        }

        private void sectorSaman_Click(object sender, EventArgs e)
        {
            rellenarComboBoxCarro();
            sectorSeleccionado = "S";
        }

        private void sectorRoble_Click(object sender, EventArgs e)
        {
            rellenarComboBoxCarro();
            sectorSeleccionado = "R";
        }

        private void sectorGuayacan_Click(object sender, EventArgs e)
        {
            rellenarComboBoxCarro();
            sectorSeleccionado = "G";
        }

        private void sectorBambu1_Click(object sender, EventArgs e)
        {
            rellenarComboBoxCarro();
            sectorSeleccionado = "B1";
        }

        private void sectorBambu2_Click(object sender, EventArgs e)
        {
            rellenarComboBoxMoto();
            sectorSeleccionado = "B2";
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

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            if (sectorSeleccionado != null && esNumero(comboBoxNPuestos.Text))
            {
                if ((esMoto && Int32.Parse(comboBoxNPuestos.Text) <= 100) || (!esMoto && Int32.Parse(comboBoxNPuestos.Text) <= 500)) //Si es moto solo se permite un numero entre 0 y 100, si es otro vehiculo es entre 0 y 500.
                {
                    Console.WriteLine("Confirmado!");
                    puestoSeleccionado = new pEstacionamiento(sectorSeleccionado, Int32.Parse(comboBoxNPuestos.Text));
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
