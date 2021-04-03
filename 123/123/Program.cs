using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _123
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirName = new DirectoryInfo(@"Загрузки");

            if (dirName.Exists)
            {
                GetDirectoryInfo(dirName);
            }
            Console.ReadKey();
        }

        public static void GetDirectoryInfo(DirectoryInfo dirName)
        {
            Console.WriteLine();
            Console.WriteLine("Подкаталоги:");
            DirectoryInfo[] subName = dirName.GetDirectories();
            foreach (var item in subName)
            {
                Console.WriteLine(item.FullName);
                GetDirectoryInfo(item);
            }
            Console.WriteLine();
            Console.WriteLine("Файлы:");
            FileInfo[] files = dirName.GetFiles();
            foreach (var item in files)
            {
                if (item.Extension == ".txt" || item.Extension == ".png")
                    Console.WriteLine(item);
            }
                Console.WriteLine();
        }
    }
}
