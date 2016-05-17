using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Vad heter du? ");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}!", name);
            Console.WriteLine();
            Console.WriteLine("Hej då {0} och ha en bra dag.", name);
            Console.ReadLine();
        }
    }
}
