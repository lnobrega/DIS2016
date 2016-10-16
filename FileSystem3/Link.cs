using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem3
{
    class Link : INode
    {
        public Link(string aName, INode aNode)
        {
            Node = aNode;
        }

        public string Name { get; set; }

        public INode Node { get; set; }

        public int Size
        {
            get
            {
                return ( Node == null ? 0 : Node.Size );
            }
        }

    }
}
