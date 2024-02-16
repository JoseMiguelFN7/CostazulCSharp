using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costazul
{
    public class pEstacionamiento
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

        public void agregarOcupantes(String cadenaOcupantes, lista listaPersonas)
        { //Para cargar los ocupantes del archivo a la lista del puesto.
            String[] arrayOcupantes = cadenaOcupantes.Split('~');
            for (int i = 0; i < arrayOcupantes.Length; i++)
            {
                String[] oc = arrayOcupantes[i].Split('/');
                vehiculo v = new vehiculo(Int32.Parse(oc[0]), oc[1], oc[2], oc[3], oc[4]);
                String[] pas = oc[5].Split('%');
                for (int j = 0; j < pas.Length; j++)
                {
                    v.getPasajeros().agregarPersonaAlFinal(listaPersonas.buscarPersonaID(Int32.Parse(pas[j])));
                }
                ocupantes.agregarVehiculoAlFinal(v);
            }
        }
    }
}
