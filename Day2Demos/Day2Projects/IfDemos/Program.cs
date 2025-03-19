using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //simpleif();
            //elseifladder();
            //nestedmethod();

            int x, y;
            Console.WriteLine("\n enter x and y co ordinates ..");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n\n The point ({x},{y}) lies in :");
            if (x == 0)
                if (y == 0)
                    Console.WriteLine("On Origin");
                else
                    Console.WriteLine("On Y -axis ");

            else
                if (y == 0)
                Console.WriteLine("On x axis ");
            else
                if (x > 0)
                if (y > 0)
                    Console.WriteLine("First Quardarant");
                else
                    Console.WriteLine("foruth quardarant");

            else
                if (y > 0)
                Console.WriteLine("second quardrant");
            else
                Console.WriteLine("Third quardrant");
            Console.ReadLine();

        }
    }
}

        //private static void elseifladder()
        //{
        //    //findina largest of four using elseif ladder without extra varaibale l
        //    int a, b, c, d;
        //    Console.WriteLine("enter values in a ,b,c,d");
        //    a = Convert.ToInt32(Console.ReadLine());
        //    b = Convert.ToInt32(Console.ReadLine());
        //    c = Convert.ToInt32(Console.ReadLine());
        //    d = Convert.ToInt32(Console.ReadLine());

        //    if ((a > b) && (a > c) && (a > d))
        //        Console.WriteLine($"The largest is {a} ");
        //    else if ((b > c) && (b > d))
        //        Console.WriteLine($"The largest is {b}");
        //    else if (c > d)
        //        Console.WriteLine($"The largest is {c}");
        //    else
        //        Console.WriteLine($"The largest is {d}");
        //}
 

        //finding the point in the quotient
      





















//        private static void nestedmethod()
//        {
//            // nested if demos 

//            int x, y, z;
//            x = 1; y = 1; z = 1;

//            if (x == 0)
//                if (y == 0)
//                    if (z == 0)
//                    {
//                        Console.WriteLine("All are zero");
//                    }
//                    else
//                    {
//                        Console.WriteLine("only x and y are zero ");
//                    }
//                else
//                {
//                    Console.WriteLine("only x is zero");
//                }
//            else
//            {
//                Console.WriteLine("All are not zero ");
//            }
//        }





//        private static void simpleif()
//        {
//            int a, b, c, d, l;
//            Console.WriteLine("enter values in a ,b,c,d");
//            a = Convert.ToInt32(Console.ReadLine());
//            b = Convert.ToInt32(Console.ReadLine());
//            c = Convert.ToInt32(Console.ReadLine());
//            d = Convert.ToInt32(Console.ReadLine());

//            l = a;
//            if (b > l)
//            {
//                l = b;
//            }
//            if (c > l)
//            {
//                l = c;
//            }
//            if (d > l)
//            {
//                l = d;
//            }
//            Console.WriteLine($"The largest number is {l}");
//        }
//    }
//}
