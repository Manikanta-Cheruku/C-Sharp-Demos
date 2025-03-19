﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo02
{
     class Program
    {
        //public static void add(int x, int y)
        //{
        //    Console.WriteLine($"The sum is :{x + y}");
        //}

        //public static int substract(int x, int y)
        //{
        //    return (x - y);
        //}

        //public static int multiply(int x, int y)
        //{
        //    return (x * y);
        //}

        public delegate void mydelegate(int x, int y);
        public delegate int mydelegate2(int x, int y);    
        static void Main(string[] args)
        {
            // delegate refercne  i am doing it anaomous function 
            mydelegate mm1 = delegate (int x, int y)
            {
                Console.WriteLine($"The sum is :{x + y}");
            };

            mm1(12, 4);

            mydelegate2 mm2 = delegate (int x, int y)
            {
                return (x - y);
            };
            Console.WriteLine($"The substractions : {mm2.Invoke(12, 4)}");

            mm2 += delegate (int x,int y)
            {
                return (x * y);
            };

            Console.WriteLine($"The multiplication is  : {mm2.Invoke(12, 6)}");
        }
    }
}
