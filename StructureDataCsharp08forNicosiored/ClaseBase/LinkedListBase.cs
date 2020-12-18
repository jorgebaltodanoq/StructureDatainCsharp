using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
     public class LinkedListBase
    {
        private readonly NodoBase headNodo;
        private NodoBase referenceNodo;
      
        public LinkedListBase()
        {
            headNodo = new NodoBase
            {
                NextNode = null
            };
        }

        /// <summary>
        /// Metodo que agrerga un nuevo NodoBasey dato a LinkedList
        /// </summary>
        /// <param name="data"></param>
        public void AddNode(dynamic data) //Miguel
        {
            referenceNodo= headNodo;

            //______Update referencia al ultimo Node________
            while (referenceNodo.NextNode != null)
            {
                referenceNodo= referenceNodo.NextNode;
            }

            #region Actualizar LinkedList
            //________________Nuevo Node______________________
            NodoBase newNodo = new NodoBase //1. Crea neuvo Node
            {
                DataNode = data, //2.Insertar dato Node
                NextNode = null  //  3. Siguiente es nulo
            };

            //______________Actualizar lista___________________
            referenceNodo.NextNode= newNodo;
            #endregion
        }

        /// <summary>
        /// Metodo que permite mostrarlo los datos que contiene los Nodes en una linkedList
        /// </summary>
        public void ViewLinkedList()
        {
            #region Titulo
            Console.WriteLine("==================\n"+ "Lista de nodos" + "\n================== \n");
            #endregion
          
            referenceNodo = headNodo; //Ubicar en NodoBasecabecera

            #region RecorrerLinkedList
            //____________Recorrer LinkedList_______________
            while (referenceNodo.NextNode != null)
            {
                //__________Mostrar Dato NodoBaseActual_________
                referenceNodo= referenceNodo.NextNode;
                var data = referenceNodo.DataNode;
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
            referenceNodo= headNodo;

            #region Condicion
            if (referenceNodo.NextNode!= null)
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
        /// Metodo que permite encontrar un NodoBaseen LinkedList
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Returnal un null en caso no exista y en caso si, retorna un NodoBasecon el dato</returns>
        public NodoBase FindNode(dynamic data, out string mensaje)
        {

            //___________________Evaluar si es vacia_______________
            referenceNodo= headNodo; // Referencia a NodoBasecabecera
            if (EmptyLinkedList(out string rspta) != true)
            {
                mensaje = rspta;
                return null;
            } //Saber si esta vacia

            //__________________Buscar Node, si no esta vacia LinkedList_______________________
            while (referenceNodo.NextNode!= null)
            {
                referenceNodo= referenceNodo.NextNode; //Actualizamos referencia
                if (referenceNodo.DataNode== data) //Evaluamos si el dato es igual al del Node
                {
                    mensaje = "\n El NodoBase encontrado es:";
                    return referenceNodo; // Retornamos el NodoBaseen caso sean iguales
                }
            }

            //__________________En caso el NodoBaseno sea encontrado_____________________
            mensaje = "\n El NodoBaseno ha sido en contrado...";
            return null;

        }

        /// <summary>
        /// Encuentra el indice de un NodoBasedado..
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int FindIndexFirst(dynamic data)
        {
            int index = -1; //Variable retornar indice.
            referenceNodo= headNodo;// Referenciar NodoBasecabecera

            while (referenceNodo.NextNode!= null)
            {
                index++;
                referenceNodo= referenceNodo.NextNode;

                if (referenceNodo.DataNode== data)
                {
                    return index;
                }

            }

            return -1;
        }

        /// <summary>
        /// Metodo que retorna el NodoBaseanterior al indicado
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public NodoBase FindNodeBefore(dynamic data)
        {
            referenceNodo= headNodo; //Referencia NodoBaseCabecera

            //________________Encuentra NodoBaseAnterior_______________
            while (referenceNodo.NextNode!= null && referenceNodo.NextNode.DataNode!= data)
                referenceNodo= referenceNodo.NextNode;

            return referenceNodo; //Retorna el NodoBaseanterior.

        }

        /// <summary>
        /// Metodo  que elimina un NodoBasede LinkedList
        /// </summary>
        public void DeleteNode(dynamic data)
        {

            //____________Verificar No estea Vacia_______________
            if (EmptyLinkedList(out _) != true) { return; }

            //____________Encontrar NodoBasetrabajar________________

            NodoBase anteriorNode= FindNodeBefore(data);//Encontramos NodoBaseanterior 
            NodoBase encontradoNode= FindNode(data, out string _);//Encontrar el Node

            //_____________Si no encuentra Node, salir____________
            if (encontradoNode== null) { return; }

            //____________Saltar Node_____________________________
            anteriorNode.NextNode= encontradoNode.NextNode;

            //___________Quitar NodoBaseActual_______________________
            encontradoNode.NextNode= null;
        }

        /// <summary>
        /// Metodo que inserta un nodo despues del nodo a especificiar
        /// </summary>
        /// <param name="data"> Data: Es la informacion del nodo</param>
        /// <param name="node">Node: Es despues del nodo en donde se insetará</param>
        public void InsertNode(dynamic data, dynamic node)
        {
            //_____________ NodoBaseReferencia Insertar________________
            referenceNodo= FindNode(node, out string _);
            if (referenceNodo== null) { return; }

            //____________Crear e Insertar Node_____________________
            NodoBase newNodo = new NodoBase { DataNode = data };
            
            //___________Trabajar Referencias Node___________________________
            newNodo.NextNode= referenceNodo.NextNode;
            referenceNodo.NextNode= newNodo;

        }

        /// <summary>
        /// Metodo que permite insertar nodos al inicio
        /// </summary>
        /// <param name="data">data: Permite ingresar el dato del nodo</param>
        public void InsertNodeFirst(dynamic data)
        {
            //________Referenciar a nodo Cabecera___________
            referenceNodo = headNodo;

            //________Crear Nuevo Nodo______________________
            NodoBase newNodo = new NodoBase { DataNode = data };

            //_______Cambiar las referencias________________
            newNodo.NextNode= referenceNodo.NextNode;
            referenceNodo.NextNode= newNodo;


        }

        /// <summary>
        /// Metodo que te retorna el indice de un nodo dado el valor 
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Index es el valor del nodo</returns>
        public NodoBase GetIndexNode(int index)
        {
            //_________Verificar si esta vacia__________
            //if (EmptyLinkedList(out string _) != true) { return null; }

            //_________Crea nuevo nodo__________
            NodoBase tempNodo= null;
            int i = -1;

            //_______________Recorrer Linkedlist____________
            referenceNodo = headNodo;

            #region While for LinkedList
            while (referenceNodo.NextNode != null)
            {
                referenceNodo = referenceNodo.NextNode;
                i++;

                if (i == index) {tempNodo = referenceNodo;}

            }
            #endregion

            return tempNodo;
        }

        public int this[int indice]
        {
            get
            {
                referenceNodo= GetIndexNode(indice);
                return referenceNodo.DataNode;
            }
            set
            {
                referenceNodo= GetIndexNode(indice);
                if (referenceNodo.NextNode!= null)
                {
                    referenceNodo.DataNode= value;

                }
            }

        }

        private void SwapNode(int valueA, int valueB, LinkedListBase lnkBase)
        {
            var temp = lnkBase[valueA];
            lnkBase[valueA] = lnkBase[valueB]; 
            lnkBase[valueB] = temp;
        }

        public int  GetLength()
        {
            referenceNodo = headNodo;
            int length = -1;

            while (referenceNodo.NextNode != null)
            {
                referenceNodo = referenceNodo.NextNode;
                length++;
            }

            return length;
        }

        public  void SortBubble( int length, LinkedListBase lnkList)
        {
            for (int outer = 1; outer < length; outer++) //14
            {
                for (int inner = 0; inner < length - outer ; inner++)  //length = 14
                {
                    if (lnkList[inner] > lnkList[inner + 1])
                    {
                        SwapNode(inner, inner + 1, lnkList);
                    }
                }
                
            }
        }
     }
}
