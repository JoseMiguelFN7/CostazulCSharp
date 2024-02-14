using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costazul
{
    internal class pila
    {
        private nodo tope;
        private int tamanio;

        public void Pila()
        {
            this.tope = null;
            this.tamanio = 0;
        }

        public Boolean esVacia()
        { //Metodo para determinar si la pila esta vacia.
            return tope == null;
        }

        public int getTamanio()
        {
            return tamanio;
        }

        public void agregarPersonaEnLaPila(persona valorPersona)
        { //Metodo para agregar personas a la pila.
            nodo nuevo = new nodo();
            nuevo.setValorPersona(valorPersona);
            if (esVacia())
            {
                tope = nuevo;
            }
            else
            {
                nuevo.setSiguiente(tope);
                tope = nuevo;
            }
            tamanio++;
        }

        public persona sacarPersonaDePila()
        { //Metodo para sacar una persona de la pila.
            persona valorPersona = null;
            if (!esVacia())
            {
                valorPersona = tope.getValorPersona();
                tope = tope.getSiguiente();
                tamanio--;
            }
            return valorPersona;
        }

        public persona verTope()
        { //para ver el tope sin retirarlo
            if (esVacia())
            {
                return null;
            }
            else
            {
                return tope.getValorPersona();
            }
        }
    }
}
