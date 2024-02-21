using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costazul
{
    public class compra
    {
        private persona comprador;
        private tienda tienda;
        private producto producto;
        private int unidades;
        private double precioTotal;
        private String tipoCompra;
        private String metodoPago;

        public compra(persona comprador, tienda tienda, producto producto, int unidades, double precioTotal, String tipocompra, String metodoPago)
        {
            this.comprador = comprador;
            this.tienda = tienda;
            this.producto = producto;
            this.unidades = unidades;
            this.precioTotal = precioTotal;
            this.tipoCompra = tipocompra;
            this.metodoPago = metodoPago;
        }

        public persona getComprador()
        {
            return comprador;
        }

        public tienda getTienda()
        {
            return tienda;
        }

        public producto getProducto()
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

        public String getTipoCompra()
        {
            return tipoCompra;
        }

        public String getMetodoPago()
        {
            return metodoPago;
        }

        public void setComprador(persona comprador)
        {
            this.comprador = comprador;
        }

        public void setTienda(tienda tienda)
        {
            this.tienda = tienda;
        }

        public void setProducto(producto producto)
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

        public void setTipoCompra(String tipocompra)
        {
            this.tipoCompra = tipocompra;
        }

        public void setMetodoPago(String metodoPago)
        {
            this.metodoPago = metodoPago;
        }

        public bool comprasIguales(compra c)
        {
            if (tienda.getNombre().Equals(c.tienda.getNombre()) && producto.getNombre().Equals(c.producto.getNombre()) && unidades == c.unidades && precioTotal == c.precioTotal && tipoCompra.Equals(c.tipoCompra) && metodoPago.Equals(c.metodoPago))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}