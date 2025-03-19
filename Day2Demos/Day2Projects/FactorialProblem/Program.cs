using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            factorial();
        }

        private static void factorial()
        {
            int f = 1;
            Console.WriteLine("Enter the number to find factorial");
            int fact = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= fact; i++)
            {
                f = f * i;

            }
            Console.WriteLine($"Factorial of {fact} is " + f);
            Console.ReadLine();
        }
    }
}
