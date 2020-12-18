using ClaseBase;
using System;

namespace AlgorithmSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedListBase();

            //Agregar nodos
            linkedList.AddNode(18); //1
            linkedList.AddNode(02); //2
            //linkedList.AddNode(50); //3
            //linkedList.AddNode(36); //4
            //linkedList.AddNode(85); //5
            //linkedList.AddNode(47); //6
            //linkedList.AddNode(21); //7
            //linkedList.AddNode(19); //8
            //linkedList.AddNode(08); //9
            //linkedList.AddNode(01); //10
            //linkedList.AddNode(98); //11
            //linkedList.AddNode(59); //12
            //linkedList.AddNode(15); //13
            //linkedList.AddNode(45); //14
            //linkedList.AddNode(65); //15

            //Mostrar los nodos.
            linkedList.ViewLinkedList();

            //Obtener tamaño LinkedList
            var length = linkedList.GetLength();

            //Ordenar los nodos
            linkedList.SortBubble(length + 1, linkedList);

            ////Mostrar los nodos ordenados
            linkedList.ViewLinkedList();

            //Permite no cerrar el programa..
            Console.WriteLine("Enter for close.");
            _ = Console.ReadLine();
        }
    }
}
