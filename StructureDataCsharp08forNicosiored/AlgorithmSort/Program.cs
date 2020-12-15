using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseBase;

namespace AlgorithmSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedListBase();

            //Agregar nodos
            linkedList.AddNode(18);
            linkedList.AddNode(02);
            linkedList.AddNode(50);
            linkedList.AddNode(36);
            linkedList.AddNode(47);
            linkedList.AddNode(85);
            linkedList.AddNode(21);
            linkedList.AddNode(19);
            linkedList.AddNode(08);
            linkedList.AddNode(01);
            linkedList.AddNode(98);
            linkedList.AddNode(59);
            linkedList.AddNode(15);
            linkedList.AddNode(45);
            linkedList.AddNode(65);

            //Mostrar los nodos.
            linkedList.ViewLinkedList();

           
            //Permite no cerrar el programa..
            Console.WriteLine("Enter for close.");
            _ = Console.ReadLine();

            
        }
    }
}
