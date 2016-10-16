using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem1
{
    public class Folder
    {
        #region Fields
        private List<File> mFiles = new List<File>();
        private List<Folder> mFolders = new List<Folder>();
        private List<Link> mLinks = new List<Link>();
        #endregion

        public Folder( string aName )
        {
            Name = aName;
        }

        public string Name { get; set; }

        public IEnumerable<File> Files { get { return mFiles; } }

        public void Add(File aFile)
        {
            mFiles.Add(aFile);
        }
        
        public IEnumerable<Folder> Folders { get { return mFolders; } }
        public void Add(Folder aFolder)
        {
            mFolders.Add(aFolder);
        }
        public IEnumerable<Link> Links { get { return mLinks; } }
        public void Add(Link aLink)
        {
            mLinks.Add(aLink);
        }
    }
}
