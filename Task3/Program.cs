using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            string[] textMass;
            StreamReader sr = new StreamReader(@"C:\Users\Svetlana\Documents\BIM\С#\ДЗ\Lesson8\Text.txt");
            while (sr.EndOfStream != true)
            {
                s += sr.ReadLine();
            }
            textMass = s.Split(' ');
            Console.WriteLine("Количество слов:");
            Console.WriteLine(textMass.Length);
            int i = 0;
            foreach (char ch in s)
            {
                i = 0;
                for (int l = 0; s.Length > l; l++)
                {
                    if (ch == s[l]) i++;
                }
                Console.WriteLine("Количество символов:");
                Console.WriteLine(i); ;
                sr.Close();
                Console.ReadLine();
            }
        }
    }
}
