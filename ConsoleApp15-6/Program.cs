using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15_6
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
            int count = 0;
            Random rud = new Random();
            for (int x = 1; x <= 15; x++)
            {

                int number = rud.Next(-20, 30);
                Console.WriteLine($"{x}-е число={number}");
                if (x > 0)
                {
                    count++;
                }
                if (x < 0)
                {
                    count--;
                }
;
            }
            Console.WriteLine($"Количество положительных чисел-{count++}");
            Console.WriteLine($"Количество отрицательных чисел-{count--}");
        }

    }
}

