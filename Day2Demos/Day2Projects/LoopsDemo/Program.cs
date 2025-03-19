using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n Start the Counter using do while");
                int counter2 = 1;
            bool Keepgoing = true;
            do
            {
                Console.Write($"{counter2} ");
                if (counter2 % 100 == 0 && counter2 != 0)
                {
                    Console.WriteLine("\n do you want to continue <y/n>?");
                    if (Console.ReadLine()  != "y")
                    {
                        Keepgoing = false;
                    }

                }

                counter2++;
            } while (Keepgoing);

            Console.ReadLine();

        }

        //int counter = 1;
        //while (counter <= 100)
        //{
        //    Console.Write($" {counter}");
        //    counter++;
        //}







        //int counter1 = 200;
        //do
        //{
        //    Console.WriteLine($" {counter1}");
        //    counter1++;
        //} while (counter1 <= 100);

        //Console.ReadLine();
        //}
    }
}

