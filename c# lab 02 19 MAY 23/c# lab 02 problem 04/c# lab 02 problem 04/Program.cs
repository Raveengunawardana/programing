using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__lab_02_problem_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Number = new int[10];


            for (int p = 0; p < 10; p++)
            {

                Console.Write("Enter numbers {0}: ", p + 1);
                Number[p] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Even numbers");

            for (int p = 0; p < 10; p++)
            {
                if (Number[p] % 2 == 0)
                {
                    Console.WriteLine(Number[p]);
                }

            }

            Console.WriteLine("odd numbers");

            for (int p = 0; p < 10; p++)
            {
                if (Number[p] % 2 == 1)
                {
                    Console.WriteLine(Number[p]);
                }
            }



            Console.ReadLine();

        }
    }
}
