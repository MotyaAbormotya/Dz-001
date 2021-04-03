using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = Console.ReadLine();
            StreamReader sr = new StreamReader($@"{fileName}", Encoding.UTF8);

            string text = sr.ReadToEnd();

            sr.Close();

            StreamWriter sw = new StreamWriter($@"{fileName}");

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLower(text[i]) == true)
                {
                    text = text.Remove(i, 1);
                    text = text.Insert(i, char.ToUpper(text[i]).ToString());
                }
                else
                {
                    text = text.Remove(i, 1);
                    text = text.Insert(i, char.ToLower(text[i]).ToString());
                }
            }

            Console.ReadKey();
            sw.Close();
        }
    }
}
