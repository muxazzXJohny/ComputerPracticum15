using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15_4
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
            Random rud = new Random();
            for (int x = 1; x <= 10; x++)
            {
                int number = rud.Next(-40, 40);
                Console.WriteLine($"{x}-е число={number}");
            }
;
        }
    }
}
