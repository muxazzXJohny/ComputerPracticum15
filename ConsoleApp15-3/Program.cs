using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15_3
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
            int count = 1;
                for (int i = 10; i <= 99; i++)
            {
                if (i%2==0) ;
                {
                    Console.WriteLine(i);count++;
                }
            }
;
        }
    }
}
