using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_03_problem_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any word");
            string str = Console.ReadLine();

            int vowelsCount = 0;

            for (int i = 0; i < str.Length; i++)
            {

                char ch = str[i];
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                {
                    vowelsCount++;
                }
            }
            Console.WriteLine(vowelsCount);

            Console.ReadLine();
        }
    }
}
