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

        public String getDatosOcupante()
        {
            if (ocupantes.Count == 0) 
            {
                return null;
            }
            String texto = "";
            for (int i = 0; i < ocupantes.Count; i++)
            {
                texto += ((persona)ocupantes[i]).getID() + "/" + ((persona)ocupantes[i]).getNombre() + "/" + ((persona)ocupantes[i]).getApellido() + "/" + ((persona)ocupantes[i]).getTci() + "/" + ((persona)ocupantes[i]).getCi() + "/" + ((persona)ocupantes[i]).getDEntrada() + "/" + ((persona)ocupantes[i]).getHEntrada() + "/" + ((persona)ocupantes[i]).getMEntrada() + "/" + ((persona)ocupantes[i]).getHSalida() + "/" + ((persona)ocupantes[i]).getMSalida() + "/" + ((persona)ocupantes[i]).getVehiculo().getID() + "/" + ((persona)ocupantes[i]).getVehiculo().getTipo() + "/" + ((persona)ocupantes[i]).getVehiculo().getPlaca() + "/" + ((persona)ocupantes[i]).getVehiculo().getColor() + "/" + ((persona)ocupantes[i]).getVehiculo().getMarca();
                if (i != ocupantes.Count - 1)
                {
                    texto += "~";
                }
            }
            return texto;
        }

        public void agregarOcupantes(String listaOcupantes)
        { //Para cargar los ocupantes del archivo a la lista del puesto.
            String[] arrayOcupantes = listaOcupantes.Split('~');
            for (int i = 0; i < arrayOcupantes.Length; i++)
            {
                String[] oc = arrayOcupantes[i].Split('/');
                persona o = new persona(Int32.Parse(oc[0]), oc[1], oc[2], oc[3], oc[4], oc[5], Int32.Parse(oc[6]), Int32.Parse(oc[7]), Int32.Parse(oc[8]), Int32.Parse(oc[9]));
                o.setVehiculo(new vehiculo(Int32.Parse(oc[10]), oc[11], oc[12], oc[13], oc[14]));
                ocupantes.Add(o);
            }
        }

        public Boolean estaOcupado(persona nuevaP)
        {
            for (int i = 0; i < ocupantes.Count; i++) 
            {
                if (!nuevaP.getVehiculo().getID().Equals(((persona)ocupantes[i]).getVehiculo().getID()))
                {
                    if (nuevaP.getDEntrada().Equals(((persona)ocupantes[i]).getDEntrada()))
                    { //Si es el mismo dia.
                      //Primero comparamos datos de entrada:
                        if (nuevaP.getHEntrada() == ((persona)ocupantes[i]).getHEntrada())
                        { //Si las horas de entrada coinciden.
                          //CASOS MINUTOS: minutos iguales, entrada nueva entre entrada y salida vieja o entrada vieja entre entrada y salida nueva
                            if ((nuevaP.getMEntrada() == ((persona)ocupantes[i]).getMEntrada()) || (nuevaP.getMEntrada() > ((persona)ocupantes[i]).getMEntrada() && nuevaP.getMEntrada() < ((persona)ocupantes[i]).getMSalida()) || (((persona)ocupantes[i]).getMEntrada() > nuevaP.getMEntrada() && ((persona)ocupantes[i]).getMEntrada() < nuevaP.getMSalida()))
                            {
                                return true; //esta ocupado en esas horas.
                            }
                        }
                        else
                        {
                            //CASOS HORAS: entrada nueva entre entrada y salida vieja o entrada vieja entre entrada y salida nueva
                            if ((nuevaP.getHEntrada() > ((persona)ocupantes[i]).getHEntrada() && nuevaP.getHEntrada() < ((persona)ocupantes[i]).getHSalida()) || (((persona)ocupantes[i]).getHEntrada() > nuevaP.getHEntrada() && ((persona)ocupantes[i]).getHEntrada() < nuevaP.getHSalida()))
                            {
                                return true;//esta ocupado en esas horas.
                            }
                        }
                        //Despues comparamos datos de salida:
                        if (nuevaP.getHSalida() == ((persona)ocupantes[i]).getHSalida())
                        { //Si las horas de salida coinciden.
                          //CASOS MINUTOS: minutos iguales, salida nueva entre entrada y salida vieja o salida vieja entre entrada y salida nueva
                            if ((nuevaP.getMSalida() == ((persona)ocupantes[i]).getMSalida()) || (nuevaP.getMSalida() > ((persona)ocupantes[i]).getMEntrada() && nuevaP.getMSalida() < ((persona)ocupantes[i]).getMSalida()) || (((persona)ocupantes[i]).getMSalida() > nuevaP.getMEntrada() && ((persona)ocupantes[i]).getMSalida() < nuevaP.getMSalida()))
                            {
                                return true; //esta ocupado en esas horas.
                            }
                        }
                        else
                        {
                            //CASOS HORAS: salida nueva entre entrada y salida vieja o salida vieja entre entrada y salida nueva
                            if ((nuevaP.getHSalida() > ((persona)ocupantes[i]).getHEntrada() && nuevaP.getHSalida() < ((persona)ocupantes[i]).getHSalida()) || (((persona)ocupantes[i]).getHSalida() > nuevaP.getHEntrada() && ((persona)ocupantes[i]).getHSalida() < nuevaP.getHSalida()))
                            {
                                return true; //esta ocupado en esas horas.
                            }
                        }
                    }
                }
            }

            return false;
        }
    }
}
