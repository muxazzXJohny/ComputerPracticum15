using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15_2
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
            
            for (int i = 2; i < 20; i++)
            {
                Console.WriteLine($"{i} штук = {i * 20.4} руб");
            }
;
        }
    }
}
