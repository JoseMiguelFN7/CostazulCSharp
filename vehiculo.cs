using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costazul
{
    internal class vehiculo
    {
        private ArrayList pasajeros;
        private String tipo;
        private String placa;
        private String color;
        private String marca;

        public vehiculo(ArrayList pasajeros, String tipo, String placa, String color, String marca)
        {
            this.pasajeros = pasajeros;
            this.tipo = tipo;
            this.placa = placa;
            this.color = color;
            this.marca = marca;
        }

        public ArrayList getPasajeros()
        {
            return pasajeros;
        }

        public String getTipo()
        {
            return tipo;
        }

        public String getPlaca()
        {
            return placa;
        }

        public String getColor()
        {
            return color;
        }

        public String getMarca()
        {
            return marca;
        }

        public void setPasajero(persona pasajero, int index)
        {
            this.pasajeros[index] = pasajero;
        }

        public void setTipo(String tipo)
        {
            this.tipo = tipo;
        }

        public void setPlaca(String placa)
        {
            this.placa = placa;
        }

        public void setColor(String color)
        {
            this.color = color;
        }

        public void setMarca(String marca)
        {
            this.marca = marca;
        }
    }
}
