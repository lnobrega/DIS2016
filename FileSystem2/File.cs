using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem2
{
    class File : Node
    {
        public File(string aName, int aSize) : base(aName, aSize)
        {
        }
    }
}
