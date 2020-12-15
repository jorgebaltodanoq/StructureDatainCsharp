using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureDataCsharp08forNicosiored
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
        public void AddNode(dynamic data) //Miguel
        {
            referenceNode = headNode;

            //______Update referencia al ultimo Node________
            while (referenceNode.NextNode != null)
            {
                referenceNode = referenceNode.NextNode;
            }

            #region Actualizar LinkedList
            //________________Nuevo Node______________________
            Node newNode = new Node(); //1. Crea neuvo Node
            newNode.DataNode = data; //  2. Insertar dato Node
            newNode.NextNode = null; //  3. Siguiente es nulo

            //______________Actualizar lista___________________
            referenceNode.NextNode = newNode;
            #endregion
        }

        /// <summary>
        /// Metodo que permite mostrarlo los datos que contiene los Nodes en una linkedList
        /// </summary>
        public void ViewLinkedList()
        {
            referenceNode = headNode; //Ubicar en Node cabecera

            #region RecorrerLinkedList
            //____________Recorrer LinkedList_______________
            while (referenceNode.NextNode != null)
            {
                //__________Mostrar Dato Node Actual_________
                referenceNode = referenceNode.NextNode;
                var data = referenceNode.DataNode;
                Console.Write($"[ {data} ] -->");
            }
            Console.Write("NULL");

            Console.WriteLine();
            #endregion
        }

        /// <summary>
        /// Permite saber si LinkedLis contiene Nodes o no
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>Retorna true si con tiene Nodes o false en caso no </returns>
        public bool EmptyLinkedList(out string cadena)
        {
            referenceNode = headNode;

            #region Condicion
            if (referenceNode.NextNode != null)
            {
                cadena = "El LinkedList contiene Nodes.";
                return true;
            }
            else
            {
                cadena = "El LinkedList esta vacia..";
                return false;
            }
            #endregion
        }

        /// <summary>
        /// Metodo que permite encontrar un Node en LinkedList
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Returnal un null en caso no exista y en caso si, retorna un Node con el dato</returns>
        public Node FindNode(dynamic data, out string mensaje)
        {

            //___________________Evaluar si es vacia_______________
            referenceNode = headNode; // Referencia a Node cabecera
            if (EmptyLinkedList(out string rspta) != true)
            {
                mensaje = rspta;
                return null;
            } //Saber si esta vacia

            //__________________Buscar Node, si no esta vacia LinkedList_______________________
            while (referenceNode.NextNode != null)
            {
                referenceNode = referenceNode.NextNode; //Actualizamos referencia
                if (referenceNode.DataNode == data) //Evaluamos si el dato es igual al del Node
                {
                    mensaje = "\n El Node encontrado es:";
                    return referenceNode; // Retornamos el Node en caso sean iguales
                }
            }

            //__________________En caso el Node no sea encontrado_____________________
            mensaje = "\n El Node no ha sido en contrado...";
            return null;

        }

        /// <summary>
        /// Encuentra el indice de un Node dado..
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int FindIndexFirst(dynamic data)
        {
            int index = -1; //Variable retornar indice.
            referenceNode = headNode;// Referenciar Node cabecera

            while (referenceNode.NextNode != null)
            {
                index++;
                referenceNode = referenceNode.NextNode;

                if (referenceNode.DataNode == data)
                {
                    return index;
                }

            }

            return -1;
        }

        /// <summary>
        /// Metodo que retorna el Node anterior al indicado
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node FindNodeBefore(dynamic data)
        {
            referenceNode = headNode; //Referencia Node Cabecera

            //________________Encuentra Node Anterior_______________
            while (referenceNode.NextNode != null && referenceNode.NextNode.DataNode != data)
                referenceNode = referenceNode.NextNode;

            return referenceNode; //Retorna el Node anterior.

        }

        /// <summary>
        /// Metodo  que elimina un Node de LinkedList
        /// </summary>
        public void DeleteNode(dynamic data)
        {

            //____________Verificar No estea Vacia_______________
            if (EmptyLinkedList(out _) != true) { return; }

            //____________Encontrar Node trabajar________________

            Node anteriorNode = FindNodeBefore(data);//Encontramos Node anterior 
            Node encontradoNode = FindNode(data, out string _);//Encontrar el Node

            //_____________Si no encuentra Node, salir____________
            if (encontradoNode == null) { return; }

            //____________Saltar Node_____________________________
            anteriorNode.NextNode = encontradoNode.NextNode;

            //___________Quitar Node Actual_______________________
            encontradoNode.NextNode = null;
        }

        /// <summary>
        /// Metodo que inserta un nodo despues del nodo a especificiar
        /// </summary>
        /// <param name="data"> Data: Es la informacion del nodo</param>
        /// <param name="node">Node: Es despues del nodo en donde se insetará</param>
        public void InsertNode(dynamic data, dynamic node)
        {
            //_____________ Node Referencia Insertar________________
            referenceNode = FindNode(node, out string _);
            if (referenceNode == null) { return; }

            //____________Crear e Insertar Node_____________________
            Node newNode = new Node();
            newNode.DataNode = data;

            //___________Trabajar Referencias Node___________________________
            newNode.NextNode = referenceNode.NextNode;
            referenceNode.NextNode = newNode;

        }

        /// <summary>
        /// Metodo que permite insertar nodos al inicio
        /// </summary>
        /// <param name="data">data: Permite ingresar el dato del nodo</param>
        public void InsertNodeFirst(dynamic data)
        {
            //________Referenciar a nodo Cabecera___________
            referenceNode = headNode;

            //________Crear Nuevo Nodo______________________
            Node newNodo = new Node();
            newNodo.DataNode = data;

            //_______Cambiar las referencias________________
            newNodo.NextNode = referenceNode.NextNode;
            referenceNode.NextNode = newNodo;


        }

        public Node GetIndexNode(int index)
        {
            //_________Verificar si esta vacia__________
            if (EmptyLinkedList(out string cadena) != true) { return null; }

            //_________Crea nuevo nodo__________
            Node tempNode = null;
            int i = -1;

            //_______________Recorrer Linkedlist____________
            referenceNode = headNode;

            #region While for LinkedList
            while (referenceNode.NextNode != null)
            {
                referenceNode = referenceNode.NextNode;
                i++;

                if (i == index)
                {
                    tempNode = referenceNode;
                }

            }
            #endregion

            return tempNode;
        }

       public dynamic this[int indice]
       {
            get 
            {
                referenceNode = GetIndexNode(indice);
                return referenceNode.DataNode;
            }
            set 
            {
                referenceNode = GetIndexNode(indice);
                if (referenceNode.NextNode != null)
                {
                    referenceNode.DataNode = value;

                }
            }

       }
        
    }
}
