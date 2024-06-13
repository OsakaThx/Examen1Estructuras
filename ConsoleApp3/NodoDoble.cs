using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircularDobleEnlazada
{
    // Clase NodoDoble, representa un nodo en la lista circular doblemente enlazada
    public class NodoDoble
    {
        public int Dato { get; set; }
        public NodoDoble Siguiente { get; set; }
        public NodoDoble Anterior { get; set; }

        public NodoDoble(int dato)
        {
            Dato = dato;
            Siguiente = null;
            Anterior = null;
        }
    }
}
