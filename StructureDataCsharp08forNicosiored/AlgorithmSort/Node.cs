using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSort
{
    class Node
    {
        public dynamic DataNode { get; set; }
        public Node NextNode { get; set; } = null;

        public Node() { }

        public override string ToString()
        {
            return string.Format($"{DataNode}");
        }
    }
}
