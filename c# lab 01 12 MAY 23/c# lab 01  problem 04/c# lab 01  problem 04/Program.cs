using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__lab_01__problem_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Your salary");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Tacx Rate");
            double tax = double.Parse(Console.ReadLine());

            double newSalary;
            double taxMoney;

            taxMoney = salary * (tax / 100);

            newSalary = salary - taxMoney;

            Console.WriteLine("Your new salary is Rs." + newSalary);



            Console.ReadLine();
        }
    }
}
