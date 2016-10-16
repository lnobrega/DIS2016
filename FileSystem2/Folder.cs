using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem2
{
    class Folder : Node
    {
        private readonly List<Node> mNodes = new List<Node>();

        public Folder( string aName ) : base( aName )
        {
        }

        public Folder() : this("Unknown")
        {
        }

        public IEnumerable<Node> Nodes { get { return mNodes; } }

        public void Add(Node aNode)
        {
            mNodes.Add( aNode );
        }

        public override int Size
        {
            get
            {
                int size = 0;
                foreach (Node node in mNodes)
                    size += node.Size;
                return size;
            }

            protected set
            {
                base.Size = value;
            }
        }
    }
}
