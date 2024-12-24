using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.ReadLine();
        }
        static void Func()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{20}\t");
            }
        }
    }
}
