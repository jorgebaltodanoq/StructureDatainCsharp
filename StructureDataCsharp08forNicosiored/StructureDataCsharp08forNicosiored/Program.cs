using System;


namespace StructureDataCsharp08forNicosiored
{
    class Program
    {
        static void Main(string[] args)
        {
            //____________Variables_______________

            //____________Instancias______________
            var lnkList = new LinkedList();


            //_____________Agrergar nuevos nodos________
            lnkList.AddNode("Juan"); //index 0
            lnkList.AddNode("Miguel"); //index 1
            lnkList.AddNode("Jorge"); //index 2
            lnkList.AddNode("Carlos"); //index 3
            lnkList.AddNode("Martin"); //index 4
            lnkList.AddNode("Roberto"); //index 5
            lnkList.AddNode("Jose"); //index 6
            lnkList.AddNode("Omar"); //index 7
            lnkList.AddNode("Lorena"); //index 8


            //___________Mostrar nodos____________________
            lnkList.ViewLinkedList();

            //___________Buscar Nodo______________________
            var findNode = lnkList.FindNode("Lorena", out string mensaje);
            Console.WriteLine(mensaje);
            Console.WriteLine($"[ {findNode} ]");

            //___________LinkedList vacia?_______________
            lnkList.EmptyLinkedList(out string cadena);
            Console.WriteLine($"\n {cadena}");

            //______________Retorna indice Nodo____________
            var indiceNode = lnkList.FindIndexFirst("Lorenzo");
            Console.WriteLine($"\n Indice Nodo: {indiceNode}");

            //______________Retorna Nodo Anterior____________
            var nodoPrevious = lnkList.FindNodeBefore("Jose");
            Console.WriteLine($"\n Nodo Anterior: {nodoPrevious}");

            //____________ Eliminar Nodo LinkedList____________
            lnkList.DeleteNode("Luismig");

            //_____________Insertar Nuevo Nodo________________
            lnkList.InsertNode("Baltodano", "Jose");

            //_____________Mostrar LinkedList_________________
            lnkList.ViewLinkedList();

            //____________Insertar Nodo la Inicio_____________
            lnkList.InsertNodeFirst("Shirley");

            //_____________Mostrar LinkedList_________________
            lnkList.ViewLinkedList();

            //____________Obtener Nodo Indice________________
            var nodeIndex = lnkList.GetIndexNode(3);
            Console.WriteLine(nodeIndex);

            //____________Indexadores_________________________
            Console.WriteLine(lnkList[5]);

            lnkList[5] = "Miguelona";

            lnkList.ViewLinkedList();



            Console.WriteLine("\n\nEnter close..");
            _ = Console.ReadLine();
        }
    }
}
