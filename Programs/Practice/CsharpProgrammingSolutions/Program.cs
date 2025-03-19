using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProgrammingSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");

           string str = Console.ReadLine();

            string rev = "";

            string temp = str;

            for (int i = str.Length-1;i >= 0; i--)
            {
                rev = rev+ str[i];
            }

            if(rev == temp)
            {
                Console.WriteLine("Given string" + " "+ temp+ " is a Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }
        }
    }
}
