using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costazul
{
    internal class pEstacionamiento
    {
        private String sector;
        private int numero;
        private lista ocupantes;

        public pEstacionamiento(String sector, int numero)
        {
            this.sector = sector;
            this.numero = numero;
            this.ocupantes = new lista();
        }

        public String getSector()
        {
            return sector;
        }

        public int getNumero()
        {
            return numero;
        }

        public lista getOcupantes()
        {
            return ocupantes;
        }

        public void agregarOcupantes(String listaOcupantes)
        { //Para cargar los ocupantes del archivo a la lista del puesto.
            String[] arrayOcupantes = listaOcupantes.Split('~');
            for (int i = 0; i < arrayOcupantes.Length; i++)
            {
                String[] oc = arrayOcupantes[i].Split('/');
                persona o = new persona(Int32.Parse(oc[0]), oc[1], oc[2], oc[3], oc[4], oc[5], Int32.Parse(oc[6]), Int32.Parse(oc[7]), Int32.Parse(oc[8]), Int32.Parse(oc[9]));
                o.setVehiculo(new vehiculo(Int32.Parse(oc[10]), oc[11], oc[12], oc[13], oc[14]));
                ocupantes.agregarPersonaAlFinal(o);
            }
        }
    }
}
