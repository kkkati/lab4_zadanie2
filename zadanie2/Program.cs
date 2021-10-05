using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int plus=0;
            int minus=0;

            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    plus++;
                }
                else
                {
                    if (n < 0)
                    {
                        minus++;
                    }
                }
            } while (n != 0);
            if (plus > minus)
            {
                Console.WriteLine("Больше положительных чисел, их количество равно {0}", plus);
            }
            else
            {
                if (minus > plus)
                {
                    Console.WriteLine("Больше отрицательных чисел, их количество равно {0}", minus);
                }
                else
                {
                    if (minus == plus)
                    {   Console.WriteLine("Количесиво положительных и отрицательных чисел одинаково и равно {0}", minus);
                        }
                }
            }

            //Console.WriteLine(plus);
            Console.ReadKey();

        }
    }
}
