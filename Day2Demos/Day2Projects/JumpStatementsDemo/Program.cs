﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStatementsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ContinueDemo();
            continuewithbreakdemo();
            gotoDemo();
            Console.ReadLine();

            //i want to take some values from you & if u give negative 
            // number i will by pass the value will not take and i will take only
            // posiitve numbers and calulucate sum if i press 0 i will come out of the 
            // loop 

        }

        private static void gotoDemo()
        {
            int num;
        L1: Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                goto Test1;
            }
            else
            {
                goto L1;
            }
        Test1: Console.WriteLine("is all done");
        }

        private static void continuewithbreakdemo()
        {
            //i want to take some values from you numbers if u give negative 
            // number i will by pass the value will not take and i will take only
            // posiitve numbers and calulucate sum if i press 0 i will come out of the 
            // loop 
            int sum = 0;
            int num;
            do
            {
                Console.WriteLine("give me a number ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num < 0)
                {
                    continue;
                }
                else
                {
                    sum = sum + num;
                }

                if (num == 0)
                {
                    break;
                }

            } while (true);
            Console.WriteLine($"The sum of psositive numbers is {sum}");
        }


    




        private static void ContinueDemo()
        {
            int i = 0;
            while (i <= 10)
            {

                i++;

                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine($"{i}");
            }
        }
    }
}
