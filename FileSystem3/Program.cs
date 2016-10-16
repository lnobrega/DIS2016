using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem3
{
    class Program
    {
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

            Console.WriteLine("Folder {0} size = {1}", a.Name, a.Size);
            Console.WriteLine("Folder {0} size = {1}", b.Name, b.Size);
            Console.WriteLine("Folder {0} size = {1}", c.Name, c.Size);

            Console.ReadKey();
        }
    }
}
