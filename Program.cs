using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            String name = "";
            Console.Write("Enter your name: ");
            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.ReadLine();
        }
    }
}
