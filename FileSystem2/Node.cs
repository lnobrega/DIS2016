using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem2
{
    abstract class Node
    {
        protected Node(string aName, int aSize = 0)
        {
            Name = aName;
            Size = aSize;
        }

        public string Name { get; set; }

        public virtual int Size { get; protected set; }
    }
}
