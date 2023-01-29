using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Svetlana\Documents\BIM\С#\ДЗ\Lesson7";
            string[] dirs = Directory.GetFileSystemEntries(path, "*", SearchOption.AllDirectories); 
            foreach(string d in dirs)
            {
                Console.WriteLine(d);
            }
            Console.ReadKey();
        }    
    }
}
