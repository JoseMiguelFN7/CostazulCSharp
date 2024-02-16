using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costazul
{
    public class nodo
    {
        private persona valorPersona;
        private producto valorProducto;
        private tienda valorTienda;
        private compra valorCompra;
        private vehiculo valorVehiculo;
        private nodo siguiente;

        public nodo()
        {
            this.valorPersona = null;
            this.valorProducto = null;
            this.valorCompra = null;
            this.siguiente = null;
        }

        public void setValorPersona(persona valorPersona)
        {
            this.valorPersona = valorPersona;
        }

        public void setValorProducto(producto valorProducto)
        {
            this.valorProducto = valorProducto;
        }

        public void setValorTienda(tienda valorTienda)
        {
            this.valorTienda = valorTienda;
        }

        public void setValorCompra(compra valorCompra)
        {
            this.valorCompra = valorCompra;
        }

        public void setValorVehiculo(vehiculo valorVehiculo)
        {
            this.valorVehiculo = valorVehiculo;
        }

        public void setSiguiente(nodo siguiente)
        {
            this.siguiente = siguiente;
        }

        public persona getValorPersona()
        {
            return valorPersona;
        }

        public producto getValorProducto()
        {
            return valorProducto;
        }

        public tienda getValorTienda()
        {
            return valorTienda;
        }

        public compra getValorCompra()
        {
            return valorCompra;
        }

        public vehiculo getValorVehiculo()
        {
            return valorVehiculo;
        }

        public nodo getSiguiente()
        {
            return siguiente;
        }
    }
}
