using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem3
{
    class Folder : INode
    {
        private readonly List<INode> mNodes = new List<INode>();

        public Folder( string aName )
        {
            Name = aName;
        }

        public Folder() : this("Unknown")
        {
        }

        public string Name { get; set; }

        public IEnumerable<INode> Nodes { get { return mNodes; } }

        public void Add(INode aNode)
        {
            mNodes.Add( aNode );
        }

        public int Size
        {
            get
            {
                int size = 0;
                foreach (INode node in mNodes)
                    size += node.Size;
                return size;
            }
        }
    }
}
