using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costazul
{
    internal class compra
    {
        private persona comprador;
        private tienda tienda;
        private producto producto;
        private int unidades;
        private double precioTotal;
        private String tipocompra;
        private String metodoPago;

        public compra(persona comprador, tienda tienda, producto producto, int unidades, double precioTotal, String tipocompra, String metodoPago)
        {
            this.comprador = comprador;
            this.tienda = tienda;
            this.producto = producto;
            this.unidades = unidades;
            this.precioTotal = precioTotal;
            this.tipocompra = tipocompra;
            this.metodoPago = metodoPago;
        }

        public persona getcomprador()
        {
            return comprador;
        }

        public tienda gettienda()
        {
            return tienda;
        }

        public producto getproducto()
        {
            return producto;
        }

        public int getUnidades()
        {
            return unidades;
        }

        public double getPrecioTotal()
        {
            return precioTotal;
        }

        public String getTipocompra()
        {
            return tipocompra;
        }

        public String getMetodoPago()
        {
            return metodoPago;
        }

        public void setcomprador(persona comprador)
        {
            this.comprador = comprador;
        }

        public void settienda(tienda tienda)
        {
            this.tienda = tienda;
        }

        public void setproducto(producto producto)
        {
            this.producto = producto;
        }

        public void setUnidades(int unidades)
        {
            this.unidades = unidades;
        }

        public void setPrecioTotal(double precioTotal)
        {
            this.precioTotal = precioTotal;
        }

        public void setTipocompra(String tipocompra)
        {
            this.tipocompra = tipocompra;
        }

        public void setMetodoPago(String metodoPago)
        {
            this.metodoPago = metodoPago;
        }
    }
}
