using Costazul.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Application = System.Windows.Forms.Application;

namespace Costazul
{
    public partial class bienvenido : Form
    {
        static bool primerInicio = true;
        bool buttonPressed = false;
        public static pEstacionamiento[,] sectoresCarros = new pEstacionamiento[5,500];
        public static pEstacionamiento[,] sectoresMotos = new pEstacionamiento[2,100];
        public static lista personas = new lista();
        public static lista tiendas = new lista();
        public static int IDPersona;
        public static int IDVehiculo;
        public static string dia;
        public static int hora;
        public static int minuto;


        public bienvenido()
        {
            if (primerInicio)
            {
                IDPersona = 0;
                IDVehiculo = 0;
                cargarTiendas();
                cargarPersonas();
                cargarPuestos();
                personas.sincronizarPasajeros(); //agrega los pasajeros que corresponden a cada vehiculo en la informacion de cada persona

                Console.WriteLine(personas.getInicio().getValorPersona().getID());
                Console.WriteLine(personas.getInicio().getValorPersona().getNombre());
                Console.WriteLine(personas.getInicio().getValorPersona().getApellido());
                Console.WriteLine(personas.getInicio().getValorPersona().getTci());
                Console.WriteLine(personas.getInicio().getValorPersona().getCi());
                Console.WriteLine(personas.getInicio().getValorPersona().getDEntrada());
                Console.WriteLine(personas.getInicio().getValorPersona().getHEntrada());
                Console.WriteLine(personas.getInicio().getValorPersona().getMEntrada());
                Console.WriteLine(personas.getInicio().getValorPersona().getHSalida());
                Console.WriteLine(personas.getInicio().getValorPersona().getMSalida());
                Console.WriteLine(personas.getInicio().getValorPersona().getVehiculo().getID());
                Console.WriteLine(personas.getInicio().getValorPersona().getVehiculo().getTipo());
                Console.WriteLine(personas.getInicio().getValorPersona().getVehiculo().getMarca());
                Console.WriteLine(personas.getInicio().getValorPersona().getVehiculo().getColor());
                Console.WriteLine(personas.getInicio().getValorPersona().getVehiculo().getPlaca());
                Console.WriteLine(personas.getInicio().getValorPersona().getVehiculo().getPasajeros().getInicio().getValorPersona().getNombre());
                Console.WriteLine(".");
            }
            else
            {
                //Actualizar el archivo de puestos.
                String texto = "";
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 500; j++)
                    {
                        if (sectoresCarros[i, j].getOcupantes().esVacia())
                        {
                            texto += sectoresCarros[i, j].getSector() + "_" + sectoresCarros[i, j].getNumero() + "_" + "no" + "\n";
                        }
                        else
                        {
                            texto += sectoresCarros[i, j].getSector() + "_" + sectoresCarros[i, j].getNumero() + "_" + sectoresCarros[i, j].getOcupantes().getDatosOcupantes() + "\n";
                        }
                    }
                    if (i != 4)
                    {
                        texto += "-" + "\n";
                    }
                }

                texto += "%" + "\n";
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        if (sectoresMotos[i, j].getOcupantes().esVacia())
                        {
                            texto += sectoresMotos[i, j].getSector() + "_" + sectoresMotos[i, j].getNumero() + "_" + "no" + "\n";
                        }
                        else
                        {
                            texto += sectoresMotos[i, j].getSector() + "_" + sectoresMotos[i, j].getNumero() + "_" + sectoresMotos[i, j].getOcupantes().getDatosOcupantes() + "\n";
                        }
                    }
                    if (i != 1)
                    {
                        texto += "-" + "\n";
                    }
                }
                string ruta = Path.Combine(Application.StartupPath, "archivostxt\\Puestos.txt");
                archivo.escribirArchivo(texto, ruta);

                //Actualizar el archivo de personas.
                ruta = Path.Combine(Application.StartupPath, "archivostxt\\Personas.txt");
                texto = personas.obtenerStringPersonas();
                archivo.escribirArchivo(texto, ruta);
            }

            InitializeComponent();
            this.ClientSize = fondo.Size;
            label1.Parent = fondo;
        }

        public void cargarPuestos()
        {
            string ruta = Path.Combine(Application.StartupPath, "archivostxt\\Puestos.txt");
            String texto = archivo.leerArchivo(ruta);
            if (texto == null)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 500; j++)
                    {
                        switch (i)
                        {
                            case 0:
                                texto = "M";
                                break;
                            case 1:
                                texto = "S";
                                break;
                            case 2:
                                texto = "R";
                                break;
                            case 3:
                                texto = "G";
                                break;
                            case 4:
                                texto = "B1";
                                break;
                        }
                        sectoresCarros[i,j] = new pEstacionamiento(texto, j + 1);
                    }
                }

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        switch (i)
                        {
                            case 0:
                                texto = "P";
                                break;
                            case 1:
                                texto = "B2";
                                break;
                        }
                        sectoresMotos[i,j] = new pEstacionamiento(texto, j + 1);
                    }
                }

                texto = "";
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 500; j++)
                    {
                        texto += sectoresCarros[i,j].getSector() + "_" + sectoresCarros[i,j].getNumero() + "_" + "no" + "\n";
                    }
                    if (i != 4)
                    {
                        texto += "-" + "\n";
                    }
                }
                texto += "%" + "\n";
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        texto += sectoresMotos[i,j].getSector() + "_" + sectoresMotos[i,j].getNumero() + "_" + "no" + "\n";
                    }
                    if (i != 1)
                    {
                        texto += "-" + "\n";
                    }
                }

                archivo.escribirArchivo(texto, ruta);
            }
            else
            {
                String[] separador1 = { "\n%\n" };
                String[] arreglosCM = texto.Split(separador1, StringSplitOptions.RemoveEmptyEntries);
                String[] separador2 = { "\n-\n" };
                String[] sectoresC = arreglosCM[0].Split(separador2, StringSplitOptions.RemoveEmptyEntries);
                String[] sectoresM = arreglosCM[1].Split(separador2, StringSplitOptions.RemoveEmptyEntries);
                String[] puestosM = sectoresC[0].Split('\n');
                String[] puestosS = sectoresC[1].Split('\n');
                String[] puestosR = sectoresC[2].Split('\n');
                String[] puestosG = sectoresC[3].Split('\n');
                String[] puestosB1 = sectoresC[4].Split('\n');
                String[] puestosP = sectoresM[0].Split('\n');
                String[] puestosB2 = sectoresM[1].Split('\n');
                String[][] pM = new String[500][];
                String[][] pS = new String[500][];
                String[][] pR = new String[500][];
                String[][] pG = new String[500][];
                String[][] pB1 = new String[500][];
                
                //Carga de puestos de vehiculos al sistema

                for (int i = 0; i < 500; i++)
                {
                    pM[i] = puestosM[i].Split('_');
                    pS[i] = puestosS[i].Split('_');
                    pR[i] = puestosR[i].Split('_');
                    pG[i] = puestosG[i].Split('_');
                    pB1[i] = puestosB1[i].Split('_');
                }
                foreach (String[] p in pM)
                {
                    sectoresCarros[0, Int32.Parse(p[1]) - 1] = new pEstacionamiento(p[0], Int32.Parse(p[1]));
                    if (!p[2].Equals("no"))
                    {
                        sectoresCarros[0, Int32.Parse(p[1]) - 1].agregarOcupantes(p[2], personas);
                    }
                }

                foreach (String[] p in pS)
                {
                    sectoresCarros[1, Int32.Parse(p[1]) - 1] = new pEstacionamiento(p[0], Int32.Parse(p[1]));
                    if (!p[2].Equals("no"))
                    {
                        sectoresCarros[1, Int32.Parse(p[1]) - 1].agregarOcupantes(p[2], personas);
                    }
                }

                foreach (String[] p in pR)
                {
                    sectoresCarros[2, Int32.Parse(p[1]) - 1] = new pEstacionamiento(p[0], Int32.Parse(p[1]));
                    if (!p[2].Equals("no"))
                    {
                        sectoresCarros[2, Int32.Parse(p[1]) - 1].agregarOcupantes(p[2], personas);
                    }
                }

                foreach (String[] p in pG)
                {
                    sectoresCarros[3, Int32.Parse(p[1]) - 1] = new pEstacionamiento(p[0], Int32.Parse(p[1]));
                    if (!p[2].Equals("no"))
                    {
                        sectoresCarros[3, Int32.Parse(p[1]) - 1].agregarOcupantes(p[2], personas);
                    }
                }

                foreach (String[] p in pB1)
                {
                    sectoresCarros[4, Int32.Parse(p[1]) - 1] = new pEstacionamiento(p[0], Int32.Parse(p[1]));
                    if (!p[2].Equals("no"))
                    {
                        sectoresCarros[4, Int32.Parse(p[1]) - 1].agregarOcupantes(p[2], personas);
                    }
                }

                //Carga de puestos de motos al sistema

                String[][] pP = new String[100][];
                String[][] pB2 = new String[100][];

                for (int i = 0; i < 100; i++)
                {
                    pP[i] = puestosP[i].Split('_');
                    pB2[i] = puestosB2[i].Split('_');
                }

                foreach (String[] p in pP)
                {
                    sectoresMotos[0, Int32.Parse(p[1]) - 1] = new pEstacionamiento(p[0], Int32.Parse(p[1]));
                    if (!p[2].Equals("no"))
                    {
                        sectoresMotos[0, Int32.Parse(p[1]) - 1].agregarOcupantes(p[2], personas);
                    }
                }

                foreach (String[] p in pB2)
                {
                    sectoresMotos[1, Int32.Parse(p[1]) - 1] = new pEstacionamiento(p[0], Int32.Parse(p[1]));
                    if (!p[2].Equals("no"))
                    {
                        sectoresMotos[1, Int32.Parse(p[1]) - 1].agregarOcupantes(p[2], personas);
                    }
                }
            }
        }

        private void cargarTiendas()
        {
            string ruta = Path.Combine(Application.StartupPath, "archivostxt\\Tiendas.txt");
            String texto = archivo.leerArchivo(ruta);

            string[] stringTiendas = texto.Split('\n');

            foreach (String t in stringTiendas)
            {
                string[] datosTiendas = t.Split('_');
                tiendas.agregarTiendaAlFinal(new tienda(datosTiendas[0], datosTiendas[1], datosTiendas[2], Int32.Parse(datosTiendas[3]), datosTiendas[4]));
            }
        }

        private void cargarPersonas()
        {
            string ruta = Path.Combine(Application.StartupPath, "archivostxt\\Personas.txt");
            String s = archivo.leerArchivo(ruta);
            if (String.IsNullOrEmpty(s))
            {
                archivo.escribirArchivo("", ruta); //Si no existe, lo crea
                return;
            }
            String[] arrayPersonas = s.Split('\n');
            foreach (String persona in arrayPersonas)
            {
                String[] datosPersona = persona.Split('_');
                persona p = new persona(Int32.Parse(datosPersona[0]), datosPersona[1], datosPersona[2], datosPersona[3], datosPersona[4], datosPersona[5], Int32.Parse(datosPersona[6]), Int32.Parse(datosPersona[7]), Int32.Parse(datosPersona[8]), Int32.Parse(datosPersona[9]));
                if (datosPersona[10].Equals("no"))
                {
                    p.setVehiculo(null);
                }
                else
                {
                    String[] datosVehiculo = datosPersona[10].Split('/');
                    p.setVehiculo(new vehiculo(Int32.Parse(datosVehiculo[0]), datosVehiculo[1], datosVehiculo[2], datosVehiculo[3], datosVehiculo[4]));
                    if (p.getVehiculo().getID() >= bienvenido.IDVehiculo)
                    {
                        bienvenido.IDVehiculo = p.getVehiculo().getID() + 1;
                    }
                }
                if (!datosPersona[11].Equals("no"))
                {
                    String[] datoscompras = datosPersona[11].Split('-');
                    foreach (String datoscompra in datoscompras)
                    {
                        String[] compra = datoscompra.Split('/');
                        compra c = new compra(p, bienvenido.tiendas.buscarTiendaLocal(Int32.Parse(compra[0])), bienvenido.tiendas.buscarTiendaLocal(Int32.Parse(compra[0])).getProductos().buscarProducto(compra[1]), Int32.Parse(compra[2]), Double.Parse(compra[3]), compra[4], compra[5]);
                        p.getCompras().agregarCompraAlFinal(c);
                    }
                }
                if (p.getID() >= IDPersona)
                {
                    IDPersona = p.getID() + 1;
                }
                personas.agregarPersonaAlFinal(p);
            }
        }

        private void bienvenido_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!buttonPressed)
            {
                Application.Exit();
            }
        }


        private void comboBoxHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMinuto.Items.Clear();
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
            comboBoxMinuto.SelectedIndex = 0;
            comboBoxMinuto.Visible = true;
        }

        private void comboBoxDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxHora.Items.Clear();
            if (comboBoxDia.SelectedItem.ToString().Equals("Domingo"))
            {
                for (int i = 12; i < 20; i++)
                {
                    comboBoxHora.Items.Add(i.ToString());
                }
            }
            else
            {
                for (int i = 11; i < 21; i++)
                {
                    comboBoxHora.Items.Add(i.ToString());
                }
            }
            comboBoxHora.SelectedIndex = 0;
            comboBoxHora.Visible = true;
        }




        private void comboBoxMinuto_VisibleChanged(object sender, EventArgs e)
        {
            ButtonConfirmar.Enabled = true;
        }

        private void comboBoxMinuto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dia = comboBoxDia.SelectedItem.ToString();
            hora = Int32.Parse(comboBoxHora.SelectedItem.ToString());
            minuto = Int32.Parse(comboBoxMinuto.SelectedItem.ToString());
            buttonPressed = true;
            formRegistroUsuarios ru = new formRegistroUsuarios();
            ru.Show();
            if (primerInicio)
            {
                primerInicio = false;
                this.Hide();
            }
            else
            {
                this.Close();
            }
        }
    }
}