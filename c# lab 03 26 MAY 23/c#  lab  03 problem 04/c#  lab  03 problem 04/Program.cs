using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c___lab__03_problem_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] possitiveInt = new int[10];
            int sum = 0;
            for (int i = 0; i < possitiveInt.Length; i++)
            {
                Console.Write("enter only possitive number: ", i + 1);
                possitiveInt[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < possitiveInt.Length; i++)
            {

                if (possitiveInt[i] / 2 == 1)
                {

                    sum = sum + possitiveInt[i];

                }

            }
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
