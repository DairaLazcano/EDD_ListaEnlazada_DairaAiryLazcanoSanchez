using System;
using System.Collections.Generic;
using System.Text;

namespace EDD_ListaEnlazada_DairaAiryLazcanoSanchez
{
    public class Nodo
    {
        //campos
        private int dato;
        private Nodo siguiente;

        //metodos
        public Nodo(int dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }

        //propiedades
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }


    
    }
}
