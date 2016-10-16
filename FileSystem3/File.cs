using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem3
{
    class File : INode
    {
        public File(string aName, int aSize)
        {
            Name = aName;
            Size = aSize;
        }

        public string Name { get; set; }
 
        public int Size { get; set; }
    }
}
