using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ВВ_ФИБОНАЧИ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("До якого числа рахувати ряд Фiбоначчi?");
            int number = Convert.ToInt32(Console.ReadLine());

            int perv = 1;
            Console.Write("{0} ", perv);
            int vtor = 1;
            Console.Write("{0} ", vtor);
            int sum = 0;

            while (number>=sum)
            {
                sum = perv + vtor;

                Console.WriteLine("{0} ", sum);

                perv = vtor;
                vtor = sum;
                System.Threading.Thread.Sleep(50);
            }

            Console.WriteLine();
            Console.WriteLine("До якого числа рахувати ряд простих чисел");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= input; i++)
            {
                int j;
                for (j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                }
                if (j > Math.Sqrt(i))
                {
                    Console.WriteLine(i);
                    System.Threading.Thread.Sleep(50);
                }

            }
        }
    }
}
