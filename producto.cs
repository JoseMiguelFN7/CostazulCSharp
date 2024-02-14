using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costazul
{
    internal class producto
    {
        private String nombre;
        private String descripcion;
        private double precio;

        public producto(String nombre, String descripcion, double precio)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        public String getNombre()
        {
            return nombre;
        }

        public String getDescripcion()
        {
            return descripcion;
        }

        public double getPrecio()
        {
            return precio;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setDescripcion(String descripcion)
        {
            this.descripcion = descripcion;
        }

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }
    }
}
