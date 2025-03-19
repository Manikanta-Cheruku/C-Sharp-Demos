using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2projects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            object objone; //ref
            int numberone; //value
            numberone = 77;
            objone = numberone; //Boxing

            Console.WriteLine($"objectone is {objone}"); //unboxing

            //Boxing: Converting a string value to an object type
            string originalString = "Hello,Boxing and Unboxig!";
            object boxedString = originalString;

            Console.WriteLine("Boxed String: " + boxedString);

            //unboxing : Converting a  onj back to string

            string unboxedString = (string)boxedString;

            Console.WriteLine("Unboxed string: " + unboxedString);

            // Check if the original and unboxed strings are equal
            if (originalString.Equals(unboxedString))
            {
                Console.WriteLine("The original and unboxed strings are equal.");
            }


            Console.ReadLine();
        }
    }
}
