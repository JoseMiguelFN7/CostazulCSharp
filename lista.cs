using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costazul
{
    public class lista
    {
        private nodo inicio;
        private int tamanio;

        public lista()
        {
            this.inicio = null;
            this.tamanio = 0;
        }

        public nodo getInicio()
        {
            return inicio;
        }

        public int getTamanio()
        {
            return tamanio;
        }

        public Boolean esVacia()
        {
            return inicio == null;
        }

        public void agregarPersonaAlFinal(persona p)
        { //metodo para agregar una persona al final de la lista
            nodo nuevo = new nodo();
            nuevo.setValorPersona(p);
            if (esVacia())
            {
                inicio = nuevo;
            }
            else
            {
                nodo aux = inicio;
                while (aux.getSiguiente() != null)
                {
                    aux = aux.getSiguiente();
                }
                aux.setSiguiente(nuevo);
            }
            tamanio++;
        }

        public void eliminarPersona(persona p)
        { //metodo para eliminar una persona de la lista.
            if (!esVacia())
            {
                if (inicio.getValorPersona().getID() == p.getID())
                {
                    inicio = inicio.getSiguiente();
                }
                else
                {
                    nodo aux = inicio;
                    while (aux.getSiguiente() != null)
                    {
                        if (aux.getSiguiente().getValorPersona().getID() == p.getID())
                        {
                            aux.setSiguiente(aux.getSiguiente().getSiguiente());
                            return;
                        }
                        aux = aux.getSiguiente();
                    }
                }
            }
        }

        public persona buscarPersonaID(int ID)
        { //para buscar un producto en la lista
            if (esVacia())
            {
                return null;
            }
            else
            {
                nodo aux = inicio;
                while (aux != null)
                {
                    if (aux.getValorPersona().getID() == ID)
                    {
                        return aux.getValorPersona();
                    }
                    aux = aux.getSiguiente();
                }
                return null;
            }
        }

        public String getIDPasajeros()
        { //Para conseguir los IDs de los pasajeros de un vehiculo en una string
            if (esVacia())
            {
                return null;
            }
            String texto = "";
            nodo aux = inicio;
            while (aux != null)
            {
                texto += aux.getValorPersona().getID();
                if (aux.getSiguiente() != null)
                {
                    texto += "%";
                }
                aux = aux.getSiguiente();
            }
            return texto;
        }

        public String getDatosOcupantes()
        { //Para conseguir los datos de los vehiculos ocupantes de un puesto en una string
            if (esVacia())
            {
                return null;
            }
            String texto = "";
            nodo aux = inicio;
            while (aux != null)
            {
                texto += aux.getValorVehiculo().getID() + "/" + aux.getValorVehiculo().getTipo() + "/" + aux.getValorVehiculo().getPlaca() + "/" + aux.getValorVehiculo().getColor() + "/" + aux.getValorVehiculo().getMarca() + "/" + aux.getValorVehiculo().getPasajeros().getIDPasajeros();
                if (aux.getSiguiente() != null)
                {
                    texto += "~";
                }
                aux = aux.getSiguiente();
            }
            return texto;
        }

        public void agregarProductoAlFinal(producto p)
        { //metodo para agregar un producto al final de la lista
            nodo nuevo = new nodo();
            nuevo.setValorProducto(p);
            if (esVacia())
            {
                inicio = nuevo;
            }
            else
            {
                nodo aux = inicio;
                while (aux.getSiguiente() != null)
                {
                    aux = aux.getSiguiente();
                }
                aux.setSiguiente(nuevo);
            }
            tamanio++;
        }

        public void agregarCompraAlFinal(compra c)
        { //para agregar una compra al final de la lista
            nodo nuevo = new nodo();
            nuevo.setValorCompra(c);
            if (esVacia())
            {
                inicio = nuevo;
            }
            else
            {
                nodo aux = inicio;
                while (aux.getSiguiente() != null)
                {
                    aux = aux.getSiguiente();
                }
                aux.setSiguiente(nuevo);
            }
            tamanio++;
        }

        public void agregarVehiculoAlFinal(vehiculo v)
        { //para agregar una vehiculo al final de la lista
            nodo nuevo = new nodo();
            nuevo.setValorVehiculo(v);
            if (esVacia())
            {
                inicio = nuevo;
            }
            else
            {
                nodo aux = inicio;
                while (aux.getSiguiente() != null)
                {
                    aux = aux.getSiguiente();
                }
                aux.setSiguiente(nuevo);
            }
            tamanio++;
        }

        public bool puestoOcupado(persona ocupanteNuevo) //metodo para saber si el puesto esta ocupado a una hora determinada
        {
            nodo aux = inicio;
            while (aux != null)
            {
                persona ocupanteViejo = aux.getValorVehiculo().getPasajeros().getInicio().getValorPersona();
                if (ocupanteNuevo.getDEntrada().Equals(ocupanteViejo.getDEntrada()))
                { //Si es el mismo dia.
                  //Primero comparamos datos de entrada:
                    if (ocupanteNuevo.getHEntrada() == ocupanteViejo.getHEntrada())
                    { //Si las horas de entrada coinciden.
                      //CASOS MINUTOS: minutos iguales, entrada nueva entre entrada y salida vieja o entrada vieja entre entrada y salida nueva
                        if ((ocupanteNuevo.getMEntrada() == ocupanteViejo.getMEntrada()) || (ocupanteNuevo.getMEntrada() > ocupanteViejo.getMEntrada() && ocupanteNuevo.getMEntrada() < ocupanteViejo.getMSalida()) || (ocupanteViejo.getMEntrada() > ocupanteNuevo.getMEntrada() && ocupanteViejo.getMEntrada() < ocupanteNuevo.getMSalida()))
                        {
                            return true; //esta ocupado en esas horas.
                        }
                    }
                    else
                    {
                        //CASOS HORAS: entrada nueva entre entrada y salida vieja o entrada vieja entre entrada y salida nueva
                        if ((ocupanteNuevo.getHEntrada() > ocupanteViejo.getHEntrada() && ocupanteNuevo.getHEntrada() < ocupanteViejo.getHSalida()) || (ocupanteViejo.getHEntrada() > ocupanteNuevo.getHEntrada() && ocupanteViejo.getHEntrada() < ocupanteNuevo.getHSalida()))
                        {
                            return true;//esta ocupado en esas horas.
                        }
                    }
                    //Despues comparamos datos de salida:
                    if (ocupanteNuevo.getHSalida() == ocupanteViejo.getHSalida())
                    { //Si las horas de salida coinciden.
                      //CASOS MINUTOS: minutos iguales, salida nueva entre entrada y salida vieja o salida vieja entre entrada y salida nueva
                        if ((ocupanteNuevo.getMSalida() == ocupanteViejo.getMSalida()) || (ocupanteNuevo.getMSalida() > ocupanteViejo.getMEntrada() && ocupanteNuevo.getMSalida() < ocupanteViejo.getMSalida()) || (ocupanteViejo.getMSalida() > ocupanteNuevo.getMEntrada() && ocupanteViejo.getMSalida() < ocupanteNuevo.getMSalida()))
                        {
                            return true; //esta ocupado en esas horas.
                        }
                    }
                    else
                    {
                        //CASOS HORAS: salida nueva entre entrada y salida vieja o salida vieja entre entrada y salida nueva
                        if ((ocupanteNuevo.getHSalida() > ocupanteViejo.getHEntrada() && ocupanteNuevo.getHSalida() < ocupanteViejo.getHSalida()) || (ocupanteViejo.getHSalida() > ocupanteNuevo.getHEntrada() && ocupanteViejo.getHSalida() < ocupanteNuevo.getHSalida()))
                        {
                            return true; //esta ocupado en esas horas.
                        }
                    }
                }
                aux = aux.getSiguiente();
            }
            return false;
        }
    }
}
