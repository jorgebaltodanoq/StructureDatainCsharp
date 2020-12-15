using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos LinkedList
            var lnkList = new LinkedList();

            //Agregar nuevos Nodos a LinkedList
            lnkList.AddNode("Juan"); //index 0
            lnkList.AddNode("Miguel"); //index 1
            lnkList.AddNode("Jorge"); //index 2
            lnkList.AddNode("Carlos"); //index 3
            lnkList.AddNode("Martin"); //index 4
            lnkList.AddNode("Roberto"); //index 5
            lnkList.AddNode("Jose"); //index 6
            lnkList.AddNode("Omar"); //index 7
            lnkList.AddNode("Lorena"); //index 8

            //lnkList.AddNode(18);
            //lnkList.AddNode(1);
            //lnkList.AddNode(20);
            //lnkList.AddNode(53);
            //lnkList.AddNode(25);
            //lnkList.AddNode(078);
            //lnkList.AddNode(10);
            //lnkList.AddNode(09);
            //lnkList.AddNode(68);

            //Mostrar nodos LinkedList
            lnkList.ViewLinkedList("NODOS DE LINKEDLIST");



            //Permite no cerrar el programa..
            Console.WriteLine("Enter for close.");
            _ = Console.ReadLine();

        }
    }
}
