using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costazul
{
    public class tienda
    {
        private String nombre;
        private String encargado;
        private String ubicacion;
        private int local;
        private lista productos;

        public tienda(String nombre, String encargado, String ubicacion, int local, String productos)
        {
            this.nombre = nombre;
            this.encargado = encargado;
            this.ubicacion = ubicacion;
            this.local = local;
            this.productos = new lista();

            String[] arrayproductos = productos.Split('-'); //Para cargar la lista de productos del archivo
            foreach (String datosproducto in arrayproductos)
            {
                String[] datProd = datosproducto.Split('/');
                producto p = new producto(datProd[0], datProd[1], Double.Parse(datProd[2]));
                this.productos.agregarProductoAlFinal(p);
            }
        }

        public String getNombre()
        {
            return nombre;
        }

        public String getEncargado()
        {
            return encargado;
        }

        public String getUbicacion()
        {
            return ubicacion;
        }

        public int getLocal()
        {
            return local;
        }

        public lista getProductos()
        {
            return productos;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setEncargado(String encargado)
        {
            this.encargado = encargado;
        }

        public void setUbicacion(String ubicacion)
        {
            this.ubicacion = ubicacion;
        }

        public void setLocal(int local)
        {
            this.local = local;
        }
    }
}
