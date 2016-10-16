using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem1
{
    public class Link
    {
        public Link( string aName, File aFile )
        {
            File = aFile;
        }

        public Link(string aName, Folder aFolder)
        {
            Folder = aFolder;
        }

        public File File { get; set; }
        public Folder Folder { get; set; }

    }
}
