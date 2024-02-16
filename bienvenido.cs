using Costazul.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
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
        static int IDPersona;
        static int IDVehiculo;

        public bienvenido()
        {

            if (primerInicio)
            {
                archivoPuestos();
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
            }

            InitializeComponent();
        }

        public void archivoPuestos()
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
                Console.WriteLine(pM.Length);
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

        private void bienvenido_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!buttonPressed)
            {
                Application.Exit();
            }
        }
    }
}
