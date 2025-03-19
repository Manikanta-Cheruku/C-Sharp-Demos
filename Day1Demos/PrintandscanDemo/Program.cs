using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintandscanDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x, y, z;
            Console.WriteLine("enter values in x and y...");
            x = Convert.ToInt32(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            z = x + y;

            Console.WriteLine($"The sum of {x} and {y} is {z}");
            Console.ReadLine();

            //printing constants
            Console.WriteLine("printing constant value without kepping inside variable : {0}", 34.56);
            Console.WriteLine($"February has either {28} or {29}");

            //taking value in a single line
            Console.WriteLine("\nenter values in a single line");

            string input = Console.ReadLine();
            int m, n;
            m = Convert.ToInt32(input.Split(',')[0]);
            n = Convert.ToInt32(input.Split(',')[1]);
            Console.WriteLine($"The sum of {m} and {n} are {m + n}");

            Console.WriteLine("\nenter values in a single line but choose the delimeter");

            char[] chars = new char[] { ',', '-', '_', '.', '$' };

            string input2 = Console.ReadLine();

            int m1, n1;

            m1 = Convert.ToInt32(input2.Split(chars)[0]);
            n1 = Convert.ToInt32(input2.Split(chars)[1]);

            Console.WriteLine($"The sum of {m1} and {n1} is {m1 + n1}");


            Console.WriteLine($"Int max value and min value is {int.MaxValue} and {int.MinValue}");

            Console.WriteLine($"Byte max value and min value is {Byte.MaxValue} and {Byte.MinValue}");

            Console.ReadLine();




        }
    }
}


//using System;

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Hello, World!!");
//    }
//}