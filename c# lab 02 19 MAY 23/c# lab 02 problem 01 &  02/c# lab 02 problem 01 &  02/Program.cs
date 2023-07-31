using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__lab_02_problem_01____02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //problem 01 and 02//

            Console.Write("Enter the first number : ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number : ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the operator (+,-,*,/): ");
            char operation = Convert.ToChar(Console.ReadLine());

            double result;

            switch (operation)
            {

                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Addition is " + result);
                    break;

                case '-':
                    result = num2 - num1;
                    Console.WriteLine("subtraction is " + result); break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine("summation is " + result); break;

                case '/':
                    result = num1 / num2;
                    Console.WriteLine("Divition is " + result); break;
            }
            Console.ReadLine();
        }

    }
}
