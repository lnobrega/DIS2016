using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem2
{
    class Link : Node
    {
        public Link(string aName, Node aNode) : base(aName)
        {
            Node = aNode;
        }

        public Node Node { get; set; }

        public override int Size
        {
            get
            {
                return ( Node == null ? 0 : Node.Size );
            }

            protected set
            {
                base.Size = value;
            }
        }

    }
}
