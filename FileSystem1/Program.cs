using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem1
{
    class Program
    {
        static int GetSize(Folder aFolder)
        {
            int size = 0;

            foreach (File file in aFolder.Files)
                size += file.Size;

            foreach (Folder folder in aFolder.Folders)
                size += GetSize(folder);

            foreach (Link link in aFolder.Links)
            {
                if (link.File != null)
                    size += link.File.Size;
                else
                    size += GetSize(link.Folder);
            }

            return size;
        }
        static void Main(string[] args)
        {
            Folder a = new Folder("A");
            Folder b = new Folder("B");
            Folder c = new Folder("C");

            a.Add(b);
            a.Add(c);

            File f1 = new File("F1", 100);
            File f2 = new File("F2", 200);
            File f3 = new File("F3", 300);

            a.Add(f1);
            b.Add(f2);
            c.Add(f3);

            Link link = new Link("link para f3", f3);
            a.Add(link);

            Console.WriteLine("Folder {0} size = {1}", a.Name, GetSize(a));
            Console.WriteLine("Folder {0} size = {1}", b.Name, GetSize(b));
            Console.WriteLine("Folder {0} size = {1}", c.Name, GetSize(c));

            Console.ReadKey();
        }
    }
}
