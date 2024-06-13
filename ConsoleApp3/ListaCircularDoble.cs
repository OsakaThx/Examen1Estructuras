using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircularDobleEnlazada
{
    // Clase ListaCircularDoble, maneja la lógica de la lista circular doblemente enlazada
    public class ListaCircularDoble
    {
        private NodoDoble cabeza;

        public ListaCircularDoble()
        {
            cabeza = null;
        }

        // Método para insertar un nuevo nodo al final de la lista
        public void Insertar(int dato)
        {
            NodoDoble nuevoNodo = new NodoDoble(dato);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cabeza.Siguiente = cabeza;
                cabeza.Anterior = cabeza;
            }
            else
            {
                NodoDoble ultimo = cabeza.Anterior;
                ultimo.Siguiente = nuevoNodo;
                nuevoNodo.Anterior = ultimo;
                nuevoNodo.Siguiente = cabeza;
                cabeza.Anterior = nuevoNodo;
            }
        }

        // Método para eliminar un nodo de la lista (en este caso eliminaremos el primer nodo)
        public void Eliminar()
        {
            if (cabeza != null)
            {
                if (cabeza.Siguiente == cabeza)
                {
                    cabeza = null;
                }
                else
                {
                    NodoDoble ultimo = cabeza.Anterior;
                    cabeza = cabeza.Siguiente;
                    cabeza.Anterior = ultimo;
                    ultimo.Siguiente = cabeza;
                }
            }
        }

        // Método para mostrar el contenido de la lista
        public void Mostrar()
        {
            if (cabeza != null)
            {
                NodoDoble actual = cabeza;
                do
                {
                    Console.Write(actual.Dato + " ");
                    actual = actual.Siguiente;
                } while (actual != cabeza);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("La lista está vacía.");
            }
        }
    }
}
