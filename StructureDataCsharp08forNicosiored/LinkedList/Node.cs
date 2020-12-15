using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureDataCsharp08forNicosiored
{
    public class Node
    {
        public dynamic DataNode { get; set; }
        public Node NextNode { get; set; } = null;

        //Constructor
        public Node() { }

        //Metodo retorna dato.
        public override string ToString()
        {
            return string.Format($"{DataNode}");
        }
    }
}
