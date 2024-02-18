using Costazul.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Costazul
{
    public partial class formTiendas : Form
    {
        bool buttonPressed = false;
        public static tienda tiendaSeleccionada;

        public formTiendas()
        {
            InitializeComponent();
            this.ClientSize = fondo.Size;
            labelL1.Parent = fondo;
            labelL2.Parent = fondo;
            labelL3.Parent = fondo;
            labelL4.Parent = fondo;
            labelL5.Parent = fondo;
            labelL6.Parent = fondo;
            labelL7.Parent = fondo;
            labelL8.Parent = fondo;
            labelL9.Parent = fondo;
            labelL10.Parent = fondo;
            labelL11.Parent = fondo;
            labelL12.Parent = fondo;
            labelL13.Parent = fondo;
            labelL14.Parent = fondo;
            labelL15.Parent = fondo;
            labelL16.Parent = fondo;
            labelL17.Parent = fondo;
            labelL18.Parent = fondo;
            labelL19.Parent = fondo;
            labelL20.Parent = fondo;
            labelL21.Parent = fondo;
            labelL22.Parent = fondo;
            labelL23.Parent = fondo;
            labelL24.Parent = fondo;
            labelL25.Parent = fondo;
            labelL26.Parent = fondo;
            labelL27.Parent = fondo;
            labelL28.Parent = fondo;
            labelL29.Parent = fondo;
            labelL30.Parent = fondo;
            labelL31.Parent = fondo;
            labelL32.Parent = fondo;
            labelL33.Parent = fondo;
            labelL34.Parent = fondo;
            labelL35.Parent = fondo;
            labelL36.Parent = fondo;
            labelL37.Parent = fondo;
            labelL38.Parent = fondo;
            labelL39.Parent = fondo;
            labelL40.Parent = fondo;
            labelL41.Parent = fondo;
            labelL42.Parent = fondo;
            labelL43.Parent = fondo;
            labelL44.Parent = fondo;
            labelL45.Parent = fondo;
            labelL46.Parent = fondo;
            labelL47.Parent = fondo;
            labelL48.Parent = fondo;
            labelL49.Parent = fondo;
            labelL50.Parent = fondo;
            labelL51.Parent = fondo;
            labelL52.Parent = fondo;
            labelL53.Parent = fondo;
            labelL54.Parent = fondo;
            labelL55.Parent = fondo;
            labelL56.Parent = fondo;
            labelL57.Parent = fondo;
            labelL58.Parent = fondo;
            labelL59.Parent = fondo;
            labelL60.Parent = fondo;
            pictureBoxEPalma.Parent = fondo;
            pictureBoxEMangle.Parent = fondo;
            pictureBoxESaman.Parent = fondo;
            pictureBoxERoble.Parent = fondo;
            pictureBoxEGuayacan.Parent = fondo;
            pictureBoxEBambu.Parent = fondo;

            bienvenido.tiendas.llenarComboBox(comboBoxNombreTiendas);  //llena el comboBox con los nombres de las tiendas.
        }
            
        private void mostrarInfoTienda(int Local)
        {
            tienda t = bienvenido.tiendas.buscarTiendaLocal(Local);
            Console.WriteLine(t.getNombre());
            labelNombre.Text = "Nombre: " + t.getNombre();
            labelEncargado.Text = "Encargado: " + t.getEncargado();
            labelUbicacion.Text = "Ubicación: " + t.getUbicacion();
            if (bienvenido.dia.Equals("Domingo"))
            {
                labelHorario.Text = "Horario: 12:00 - 20:00";               
            }
            else
            {
                labelHorario.Text = "Horario: 11:00 - 21:00";
            }
            labelLocal.Text = "Local: " + t.getLocal();
            switch (Local)
            {
                case 1:
                    BoxLogo.Image = Resources.Multimax;
                    break;
                case 2:
                    BoxLogo.Image = Resources.GamePlanet;
                    break;
                case 3:
                    BoxLogo.Image = Resources.Her_Him;
                    break;
                case 4:
                    BoxLogo.Image = Resources.Koko_Superstore;
                    break;
                case 5:
                    BoxLogo.Image = Resources.Blasco_Joyeria;
                    break;
                case 6:
                    BoxLogo.Image = Resources.Unilook;
                    break;
                case 7:
                    BoxLogo.Image = Resources.Blackphone;
                    break;
                case 8:
                    BoxLogo.Image = Resources.Mundo_Virtual;
                    break;
                case 9:
                    BoxLogo.Image = Resources.Ecomascotas;
                    break;
                case 10:
                    BoxLogo.Image = Resources.Rori;
                    break;
                case 11:
                    BoxLogo.Image = Resources.Aero_store;
                    break;
                case 12:
                    BoxLogo.Image = Resources.Girl_MissLulu;
                    break;
                case 13:
                    BoxLogo.Image = Resources.Baby_Love;
                    break;
                case 14:
                    BoxLogo.Image = Resources.City_movil;
                    break;
                case 15:
                    BoxLogo.Image = Resources.Carolina_Herrera;
                    break;
                case 16:
                    BoxLogo.Image = Resources.Sunglass;
                    break;
                case 17:
                    BoxLogo.Image = Resources.Fitlab;
                    break;
                case 18:
                    BoxLogo.Image = Resources.Oro_margarita;
                    break;
                case 19:
                    BoxLogo.Image = Resources.Wrangler;
                    break;
                case 20:
                    BoxLogo.Image = Resources.BANDOLERA;
                    break;
                case 21:
                    BoxLogo.Image = Resources.Champions;
                    break;
                case 22:
                    BoxLogo.Image = Resources.Mele_Divani;
                    break;
                case 23:
                    BoxLogo.Image = Resources.GSL;
                    break;
                case 24:
                    BoxLogo.Image = Resources.Tarbay;
                    break;
                case 25:
                    BoxLogo.Image = Resources.Marisol_import;
                    break;
                case 26:
                    BoxLogo.Image = Resources.lucy_lingeries;
                    break;
                case 27:
                    BoxLogo.Image = Resources.Ferremetro;
                    break;
                case 28:
                    BoxLogo.Image = Resources.Sigo;
                    break;
                case 29:
                    BoxLogo.Image = Resources.Karamba_ninos;
                    break;
                case 30:
                    BoxLogo.Image = Resources.Nivel_surf;
                    break;
                case 31:
                    BoxLogo.Image = Resources.Nice_Toys;
                    break;
                case 32:
                    BoxLogo.Image = Resources.Monikerias;
                    break;
                case 33:
                    BoxLogo.Image = Resources.cerere;
                    break;
                case 34:
                    BoxLogo.Image = Resources.Miss_lulu;
                    break;
                case 35:
                    BoxLogo.Image = Resources.Tech_Star;
                    break;
                case 36:
                    BoxLogo.Image = Resources.Go_sport;
                    break;
                case 37:
                    BoxLogo.Image = Resources.Sweet_Ice;
                    break;
                case 38:
                    BoxLogo.Image = Resources.Perfumes_factory;
                    break;
                case 39:
                    BoxLogo.Image = Resources.Alta_vision;
                    break;
                case 40:
                    BoxLogo.Image = Resources.Mario_Hernandez;
                    break;
                case 41:
                    BoxLogo.Image = Resources.DIGITEC;
                    break;
                case 42:
                    BoxLogo.Image = Resources.Isha_Accessories;
                    break;
                case 43:
                    BoxLogo.Image = Resources.McPostres;
                    break;
                case 44:
                    BoxLogo.Image = Resources.Samsung;
                    break;
                case 45:
                    BoxLogo.Image = Resources.Poker_plus;
                    break;
                case 46:
                    BoxLogo.Image = Resources.Mundo_escolar;
                    break;
                case 47:
                    BoxLogo.Image = Resources.Shoe_Box;
                    break;
                case 48:
                    BoxLogo.Image = Resources.FLB;
                    break;
                case 49:
                    BoxLogo.Image = Resources.AQUA;
                    break;
                case 50:
                    BoxLogo.Image = Resources.Grupo_Selecto_s;
                    break;
                case 51:
                    BoxLogo.Image = Resources.Galaxy;
                    break;
                case 52:
                    BoxLogo.Image = Resources.Stylo_Import;
                    break;
                case 53:
                    BoxLogo.Image = Resources.Fashion_world;
                    break;
                case 54:
                    BoxLogo.Image = Resources.Techzone;
                    break;
                case 55:
                    BoxLogo.Image = Resources.Sporty_World;
                    break;
                case 56:
                    BoxLogo.Image = Resources.Rodito;
                    break;
                case 57:
                    BoxLogo.Image = Resources.McDonald_s;
                    break;
                case 58:
                    BoxLogo.Image = Resources.Arturos;
                    break;
                case 59:
                    BoxLogo.Image = Resources.Accessories_Galore;
                    break;
                case 60:
                    BoxLogo.Image = Resources.Glamour_Beauty;
                    break;
            }
            marcoPnl1.Visible = true;
            pnl1.Visible = true;
        }

        private void labelL1_MouseEnter(object sender, EventArgs e)
        {            
            mostrarInfoTienda(1);
        }

        private void labelL1_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL2_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(2);
        }

        private void labelL2_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL3_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(3);
        }

        private void labelL3_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL4_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(4);
        }
        private void labelL4_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL5_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(5);
        }

        private void labelL5_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL6_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(6);
        }

        private void labelL6_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL7_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(7);
        }

        private void labelL7_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL8_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(8);
        }

        private void labelL8_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL9_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(9);
        }

        private void labelL9_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL10_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(10);
        }

        private void labelL10_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL11_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(11);
        }

        private void labelL11_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL12_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(12);
        }

        private void labelL12_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL13_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(13);
        }

        private void labelL13_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false; 
            marcoPnl1.Visible = false;
        }

        private void labelL14_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(14);
        }

        private void labelL14_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL15_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(15);
        }

        private void labelL15_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL16_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(16);
        }

        private void labelL16_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL17_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(17);
        }

        private void labelL17_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL18_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(18);
        }

        private void labelL18_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL19_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(19);
        }

        private void labelL19_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL20_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(20);
        }

        private void labelL20_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL21_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(21);
        }

        private void labelL21_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL22_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(22);
        }

        private void labelL22_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL23_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(23);
        }

        private void labelL23_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL24_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(24);
        }

        private void labelL24_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL25_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(25);
        }

        private void labelL25_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL26_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(26);
        }

        private void labelL26_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL27_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(27);
        }

        private void labelL27_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL28_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(28);
        }

        private void labelL28_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL29_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(29);
        }

        private void labelL29_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL30_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(30);
        }

        private void labelL30_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL31_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(31);
        }

        private void labelL31_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL32_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(32);
        }

        private void labelL32_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL33_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(33);
        }

        private void labelL33_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL34_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(34);
        }

        private void labelL34_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL35_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(35);
        }

        private void labelL35_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL36_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(36);
        }

        private void labelL36_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL37_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(37);
        }

        private void labelL37_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL38_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(38);
        }

        private void labelL38_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL39_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(39);
        }

        private void labelL39_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL40_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(40);
        }

        private void labelL40_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL41_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(41);
        }

        private void labelL41_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL42_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(42);
        }

        private void labelL42_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL43_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(43);
        }

        private void labelL43_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL44_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(44);
        }

        private void labelL44_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL45_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(45);
        }

        private void labelL45_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL46_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(46);
        }

        private void labelL46_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL47_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(47);
        }

        private void labelL47_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL48_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(48);
        }

        private void labelL48_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL49_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(49);
        }

        private void labelL49_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL50_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(50);
        }

        private void labelL50_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL51_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(51);
        }

        private void labelL51_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL52_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(52);
        }

        private void labelL52_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL53_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(53);
        }

        private void labelL53_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL54_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(54);
        }

        private void labelL54_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL55_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(55);
        }

        private void labelL55_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL56_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(56);
        }

        private void labelL56_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL57_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(57);
        }

        private void labelL57_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL58_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(58);
        }

        private void labelL58_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL59_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(59);
        }

        private void labelL59_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void labelL60_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoTienda(60);
        }

        private void labelL60_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            marcoPnl1.Visible = false;
        }

        private void formTiendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!buttonPressed)
            {
                Application.Exit();
            }
        }

        private void seleccionarTienda(int local)
        {
            tiendaSeleccionada = bienvenido.tiendas.buscarTiendaLocal(local);
            marcoPanelTSeleccionada.Visible = true;
            labelTSeleccionada.Text = tiendaSeleccionada.getNombre() + " Seleccionada.";
        }

        private void labelL1_Click(object sender, EventArgs e)
        {
            seleccionarTienda(1);
        }

        private void labelL2_Click(object sender, EventArgs e)
        {
            seleccionarTienda(2);
        }

        private void labelL3_Click(object sender, EventArgs e)
        {
            seleccionarTienda(3);
        }

        private void labelL4_Click(object sender, EventArgs e)
        {
            seleccionarTienda(4);
        }

        private void labelL5_Click(object sender, EventArgs e)
        {
            seleccionarTienda(5);
        }

        private void labelL6_Click(object sender, EventArgs e)
        {
            seleccionarTienda(6);
        }

        private void labelL7_Click(object sender, EventArgs e)
        {
            seleccionarTienda(7);
        }

        private void labelL8_Click(object sender, EventArgs e)
        {
            seleccionarTienda(8);
        }

        private void labelL9_Click(object sender, EventArgs e)
        {
            seleccionarTienda(9);
        }

        private void labelL10_Click(object sender, EventArgs e)
        {
            seleccionarTienda(10);
        }

        private void labelL11_Click(object sender, EventArgs e)
        {
            seleccionarTienda(11);
        }

        private void labelL12_Click(object sender, EventArgs e)
        {
            seleccionarTienda(12);
        }

        private void labelL13_Click(object sender, EventArgs e)
        {
            seleccionarTienda(13);
        }

        private void labelL14_Click(object sender, EventArgs e)
        {
            seleccionarTienda(14);
        }

        private void labelL15_Click(object sender, EventArgs e)
        {
            seleccionarTienda(15);
        }

        private void labelL16_Click(object sender, EventArgs e)
        {
            seleccionarTienda(16);
        }

        private void labelL17_Click(object sender, EventArgs e)
        {
            seleccionarTienda(17);
        }

        private void labelL18_Click(object sender, EventArgs e)
        {
            seleccionarTienda(18);
        }

        private void labelL19_Click(object sender, EventArgs e)
        {
            seleccionarTienda(19);
        }

        private void labelL20_Click(object sender, EventArgs e)
        {
            seleccionarTienda(20);
        }

        private void labelL21_Click(object sender, EventArgs e)
        {
            seleccionarTienda(21);
        }

        private void labelL22_Click(object sender, EventArgs e)
        {
            seleccionarTienda(22);
        }

        private void labelL23_Click(object sender, EventArgs e)
        {
            seleccionarTienda(23);
        }

        private void labelL24_Click(object sender, EventArgs e)
        {
            seleccionarTienda(24);
        }

        private void labelL25_Click(object sender, EventArgs e)
        {
            seleccionarTienda(25);
        }

        private void labelL26_Click(object sender, EventArgs e)
        {
            seleccionarTienda(26);
        }

        private void labelL27_Click(object sender, EventArgs e)
        {
            seleccionarTienda(27);
        }

        private void labelL28_Click(object sender, EventArgs e)
        {
            seleccionarTienda(28);
        }

        private void labelL29_Click(object sender, EventArgs e)
        {
            seleccionarTienda(29);
        }

        private void labelL30_Click(object sender, EventArgs e)
        {
            seleccionarTienda(30);
        }

        private void labelL31_Click(object sender, EventArgs e)
        {
            seleccionarTienda(31);
        }

        private void labelL32_Click(object sender, EventArgs e)
        {
            seleccionarTienda(32);
        }

        private void labelL33_Click(object sender, EventArgs e)
        {
            seleccionarTienda(33);
        }

        private void labelL34_Click(object sender, EventArgs e)
        {
            seleccionarTienda(34);
        }

        private void labelL35_Click(object sender, EventArgs e)
        {
            seleccionarTienda(35);
        }

        private void labelL36_Click(object sender, EventArgs e)
        {
            seleccionarTienda(36);
        }

        private void labelL37_Click(object sender, EventArgs e)
        {
            seleccionarTienda(37);
        }

        private void labelL38_Click(object sender, EventArgs e)
        {
            seleccionarTienda(38);
        }

        private void labelL39_Click(object sender, EventArgs e)
        {
            seleccionarTienda(39);
        }

        private void labelL40_Click(object sender, EventArgs e)
        {
            seleccionarTienda(40);
        }

        private void labelL41_Click(object sender, EventArgs e)
        {
            seleccionarTienda(41);
        }

        private void labelL42_Click(object sender, EventArgs e)
        {
            seleccionarTienda(42);
        }

        private void labelL43_Click(object sender, EventArgs e)
        {
            seleccionarTienda(43);
        }

        private void labelL44_Click(object sender, EventArgs e)
        {
            seleccionarTienda(44);
        }

        private void labelL45_Click(object sender, EventArgs e)
        {
            seleccionarTienda(45);
        }

        private void labelL46_Click(object sender, EventArgs e)
        {
            seleccionarTienda(46);
        }

        private void labelL47_Click(object sender, EventArgs e)
        {
            seleccionarTienda(47);
        }

        private void labelL48_Click(object sender, EventArgs e)
        {
            seleccionarTienda(48);
        }

        private void labelL49_Click(object sender, EventArgs e)
        {
            seleccionarTienda(49);
        }

        private void labelL50_Click(object sender, EventArgs e)
        {
            seleccionarTienda(50);
        }

        private void labelL51_Click(object sender, EventArgs e)
        {
            seleccionarTienda(51);
        }

        private void labelL52_Click(object sender, EventArgs e)
        {
            seleccionarTienda(52);
        }

        private void labelL53_Click(object sender, EventArgs e)
        {
            seleccionarTienda(53);
        }

        private void labelL54_Click(object sender, EventArgs e)
        {
            seleccionarTienda(54);
        }

        private void labelL55_Click(object sender, EventArgs e)
        {
            seleccionarTienda(55);
        }

        private void labelL56_Click(object sender, EventArgs e)
        {
            seleccionarTienda(56);
        }

        private void labelL57_Click(object sender, EventArgs e)
        {
            seleccionarTienda(57);
        }

        private void labelL58_Click(object sender, EventArgs e)
        {
            seleccionarTienda(58);
        }

        private void labelL59_Click(object sender, EventArgs e)
        {
            seleccionarTienda(59);
        }

        private void labelL60_Click(object sender, EventArgs e)
        {
            seleccionarTienda(60);
        }

        private void comboBoxNombreTiendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            tiendaSeleccionada = bienvenido.tiendas.buscarTiendaNombre(comboBoxNombreTiendas.Text);
            marcoPanelTSeleccionada.Visible = true;
            labelTSeleccionada.Text = tiendaSeleccionada.getNombre() + " Seleccionada.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //agregar aqui codigo para abrir form de compra
        }
    }
}