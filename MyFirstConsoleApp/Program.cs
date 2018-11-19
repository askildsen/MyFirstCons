using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";

            foreach (string value in args)
            {
                result += value + " ";
            }
            Console.WriteLine(result);

            Console.WriteLine();
            Console.WriteLine("Please reply");
            string input = Console.ReadLine();
            Console.WriteLine("You wrote: \"" + input + "\". Are you serious?");
            Console.ReadKey();
        }
    }
}
