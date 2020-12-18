using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseBase;

namespace InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instace class  LinkedListBase and MethodInsertSort
            var lnkList = new LinkedListBase();
            var mtdInsertSort = new MethodInsertSort();

            //Add element at LinkedList
            #region AddNode
            lnkList.AddNode(18); //1
            lnkList.AddNode(02); //2
            lnkList.AddNode(50); //3
            lnkList.AddNode(36); //4
            lnkList.AddNode(85); //5
            lnkList.AddNode(47); //6
            lnkList.AddNode(21); //7
            lnkList.AddNode(19); //8
            lnkList.AddNode(08); //9
            lnkList.AddNode(01); //10
            lnkList.AddNode(98); //11
            lnkList.AddNode(59); //12
            lnkList.AddNode(15); //13
            lnkList.AddNode(45); //14
            lnkList.AddNode(65); //15
            #endregion
            //lnkList.AddNode(7); //10
            //lnkList.AddNode(3); //11
            //lnkList.AddNode(1); //12
            //lnkList.AddNode(2); //13
            //lnkList.AddNode(4); //14
            //lnkList.AddNode(6); //15



            //Length LinkedList
            var length = lnkList.GetLength();

            //View LinkedList
            lnkList.ViewLinkedList();

            //sorted with InsertSort
            mtdInsertSort.InsertSort(length + 1, lnkList);

            //View LinkedList
            lnkList.ViewLinkedList();

            //Stop aplication
            Console.WriteLine("\n Enter for close..");
            _ = Console.ReadLine();
        }
    }
}
