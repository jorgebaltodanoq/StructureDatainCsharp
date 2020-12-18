using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseBase;

namespace InsertSort
{
    class MethodInsertSort
    {
        private void Swap(int indexKey, int index, LinkedListBase lnkList)
        {   //                  2             1                                                        
            var temp = lnkList[indexKey]; // 1 
            lnkList[indexKey] = lnkList[index]; 
            var temp2 = lnkList[index]; ;
            lnkList[index] = temp;
            lnkList[indexKey] = temp2;

        }

        public void InsertSort(int length, LinkedListBase lnkBase)
        {           
            for (int outer = 1 ; outer < length; outer++)
            {
                var key = lnkBase[outer]; 
                             
                for (int inner = outer; inner > 0; inner--)
                {                 
                    if (key < lnkBase[inner-1])
                    {    
                        Swap(inner, inner - 1, lnkBase);
                    }
                }
            }
        }
    }
}
