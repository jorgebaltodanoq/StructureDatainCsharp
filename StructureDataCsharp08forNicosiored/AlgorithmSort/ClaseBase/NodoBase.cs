using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class NodoBase
    {
        public dynamic DataNode { get; set; }
        public NodoBase NextNode { get; set; } = null;

        public NodoBase() { }

        public override string ToString()
        {
            return string.Format($"{DataNode}");
        }
    }
}
