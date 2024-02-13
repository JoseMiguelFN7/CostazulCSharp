﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Costazul
{
    internal class archivo
    {
        public static String leerArchivo(string file)
        {
            if (File.Exists(file))
            {
                StreamReader sr = new StreamReader(file);
                string texto, line;
                line = sr.ReadLine();
                texto = line;
                while ((line = sr.ReadLine()) != null)
                {
                    texto += "\n" + line;
                }
                sr.Close();
                return texto;
            }
            return null;
        }

        public static void escribirArchivo(string texto, string file)
        {
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine(texto);
            sw.Close();
        }
    }
}
