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
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace Costazul
{
    public partial class bienvenido : Form
    {
        static Boolean primerInicio = true;
        static pEstacionamiento[,] sectoresCarros = new pEstacionamiento[5,500];
        static pEstacionamiento[,] sectoresMotos = new pEstacionamiento[2,100];
        public bienvenido()
        {
            if (primerInicio)
            {
                archivoPuestos();
            }
            InitializeComponent();
        }
        public void archivoPuestos()
        {
            string ruta = Path.Combine(Application.StartupPath, "archivostxt\\Puestos.txt");
            Console.WriteLine(ruta);
            String texto = archivo.leerArchivo(ruta);
            if (texto == null)
            {
                Console.WriteLine("ENTROOOOO");
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
                Console.WriteLine("exito");
                //agregar 2da parte de la funcion
            }
        }
    }
}
