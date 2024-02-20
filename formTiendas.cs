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
        public static Image logotienda;

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

            bienvenido.tiendas.llenarComboBoxNombre(comboBoxNombreTiendas);  //llena el comboBox con los nombres de las tiendas.
        }
        
        private Image seleccionarLogo(int Local)
        {
            switch (Local)
            {
                case 1:
                    return Resources.Multimax;
                case 2:
                    return Resources.GamePlanet;
                case 3:
                    return Resources.Her_Him;
                case 4:
                    return Resources.Koko_Superstore;
                case 5:
                    return Resources.Blasco_Joyeria;
                case 6:
                    return Resources.Unilook;
                case 7:
                    return Resources.Blackphone;
                case 8:
                    return Resources.Mundo_Virtual;
                case 9:
                    return Resources.Ecomascotas;
                case 10:
                    return Resources.Rori;
                case 11:
                    return Resources.Aero_store;
                case 12:
                    return Resources.Girl_MissLulu;
                case 13:
                    return Resources.Baby_Love;
                case 14:
                    return Resources.City_movil;
                case 15:
                    return Resources.Carolina_Herrera;
                case 16:
                    return Resources.Sunglass;
                case 17:
                    return Resources.Fitlab;
                case 18:
                    return Resources.Oro_margarita;
                case 19:
                    return Resources.Wrangler;
                case 20:
                    return Resources.BANDOLERA;
                case 21:
                    return Resources.Champions;
                case 22:
                    return Resources.Mele_Divani;
                case 23:
                    return Resources.GSL;
                case 24:
                    return Resources.Tarbay;
                case 25:
                    return Resources.Marisol_import;
                case 26:
                    return Resources.lucy_lingeries;
                case 27:
                    return Resources.Ferremetro;
                case 28:
                    return Resources.Sigo;
                case 29:
                    return Resources.Karamba_ninos;
                case 30:
                    return Resources.Nivel_surf;
                case 31:
                    return Resources.Nice_Toys;
                case 32:
                    return Resources.Monikerias;
                case 33:
                    return Resources.cerere;
                case 34:
                    return Resources.Miss_lulu;
                case 35:
                    return Resources.Tech_Star;
                case 36:
                    return Resources.Go_sport;
                case 37:
                    return Resources.Sweet_Ice;
                case 38:
                    return Resources.Perfumes_factory;
                case 39:
                    return Resources.Alta_vision;
                case 40:
                    return Resources.Mario_Hernandez;
                case 41:
                    return Resources.DIGITEC;
                case 42:
                    return Resources.Isha_Accessories;
                case 43:
                    return Resources.McPostres;
                case 44:
                    return Resources.Samsung;
                case 45:
                    return Resources.Poker_plus;
                case 46:
                    return Resources.Mundo_escolar;
                case 47:
                    return Resources.Shoe_Box;
                case 48:
                    return Resources.FLB;
                case 49:
                    return Resources.AQUA;
                case 50:
                    return Resources.Grupo_Selecto_s;
                case 51:
                    return Resources.Galaxy;
                case 52:
                    return Resources.Stylo_Import;
                case 53:
                    return Resources.Fashion_world;
                case 54:
                    return Resources.Techzone;
                case 55:
                    return Resources.Sporty_World;
                case 56:
                    return Resources.Rodito;
                case 57:
                    return Resources.McDonald_s;
                case 58:
                    return Resources.Arturos;
                case 59:
                    return Resources.Accessories_Galore;
                case 60:
                    return Resources.Glamour_Beauty;
                default:
                    return null;
            }
        }
        private void mostrarInfoTienda(int Local)
        {
            tienda t = bienvenido.tiendas.buscarTiendaLocal(Local);
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

            BoxLogo.Image = seleccionarLogo(Local);
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
            logotienda = seleccionarLogo(local);
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
            logotienda = seleccionarLogo(tiendaSeleccionada.getLocal());
            marcoPanelTSeleccionada.Visible = true;
            labelTSeleccionada.Text = tiendaSeleccionada.getNombre() + " Seleccionada.";
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            buttonPressed = true;
            formCompra c = new formCompra();
            c.Show();
            this.Close();
        }
    }
}