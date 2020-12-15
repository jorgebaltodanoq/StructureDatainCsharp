using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSort
{
    class LinkedList
    {
        public Node headNode;
        public Node referenceNode;

        public LinkedList()
        {
            headNode = new Node();
            headNode.NextNode = null;
        }

        /// <summary>
        /// Metodo que agrerga un nuevo Node y dato a LinkedList
        /// </summary>
        /// <param name="data"></param>
        public void AddNode(dynamic data)
        {
            // Enlazar head a referene
            referenceNode = headNode;

            //Actrualizar Referencia
            while (referenceNode.NextNode != null)
            {
                //Actualizar  el NextNode de referenceNode
                referenceNode = referenceNode.NextNode;
            }

            Node newNode = new Node();
            newNode.DataNode = data;
            newNode.NextNode = null;

            referenceNode.NextNode = newNode;
        }

        /// <summary>
        /// Metodo que muestra los nodos de la LinkedList
        /// </summary>
        public void ViewLinkedList(string titulo)
        {
            //Muestra un encabezado
            #region MuestraMensaje
            Console.WriteLine("------------------\n" + "LISTA DE NODOS " + "\n-----------------");
            #endregion

            //Referenciar reference a head 
            referenceNode = headNode;

            //________Recorrer LinkedList___________
            while (referenceNode.NextNode != null)
            {
                //____________Trabajar Nodos_________
                referenceNode = referenceNode.NextNode; //1. Actualizar Referencia
                var data = referenceNode.DataNode; //2. Capturar dato  del nodo
                Console.Write($"{data} ==> "); //3. Imprimir dato del nodo
            }

            Console.Write("NULL");
            Console.WriteLine();
        }


    }
}
