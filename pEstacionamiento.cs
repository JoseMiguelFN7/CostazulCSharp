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
        private ArrayList ocupantes;

        public pEstacionamiento(String sector, int numero)
        {
            this.sector = sector;
            this.numero = numero;
            this.ocupantes = new ArrayList();
        }

        public String getSector()
        {
            return sector;
        }

        public int getNumero()
        {
            return numero;
        }

        public ArrayList getOcupantes()
        {
            return ocupantes;
        }
    }
}
