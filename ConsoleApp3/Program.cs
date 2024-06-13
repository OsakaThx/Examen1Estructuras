using System;

namespace ListaCircularDobleEnlazada
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaCircularDoble lista = new ListaCircularDoble();

            // Insertamos algunos elementos en la lista
            lista.Insertar(10);
            lista.Insertar(20);
            lista.Insertar(30);

            // Mostramos el contenido de la lista
            Console.WriteLine("Contenido de la lista después de las inserciones:");
            lista.Mostrar();

            // Eliminamos un elemento de la lista
            lista.Eliminar();

            // Mostramos el contenido de la lista después de la eliminación
            Console.WriteLine("Contenido de la lista después de la eliminación:");
            lista.Mostrar();
        }
    }
}
