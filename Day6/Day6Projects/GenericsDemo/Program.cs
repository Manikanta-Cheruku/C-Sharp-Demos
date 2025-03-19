using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
//    Generics means code reuse dont write the same code repeteadely put the code inside a method and call the method repeatedly which is called as generic method
//and in the same manner dont write the same method repeteadly put the methods inside a class and use the class repeteadly called as Generic class
//when you are using generics type safety is ensured
     class Program
    {
        //public static void swap(ref int x, ref int y)
        //{
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void swap(ref DateTime x, ref DateTime y)
        //{
        //    DateTime temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //}

        static void Main(string[] args)
        {

            //Helper1.swap(ref x, ref y);
            //Console.WriteLine("\n after swapping integers");
            //Console.WriteLine($"x={x}\n y={y}");

            //DateTime date1 = DateTime.Now;
            //DateTime date2 = DateTime.Now.AddDays(2);
            //Console.WriteLine("\n Before swapping dates");
            //Console.WriteLine($"date1={date1}\n date2={date2}");
            //Helper1.swap(ref date1, ref date2);
            //Console.WriteLine("\n after swapping dates");
            //Console.WriteLine($"date1={date1}\n date2={date2}");



            //Console.WriteLine("\nAdding two numbers of double types");
            //Console.WriteLine($"The sum of doubles:{Helper1.add(123.45, 123.56)}");
            //Console.WriteLine($"The sum of ints:{Helper1.add(123, 45)}");
            //Console.ReadLine();

            int x = 10;
            int y = 20;
            Console.WriteLine("\n Before swapping integers");
            Console.WriteLine($"x={x}\n y={y}");

            Helper2<int>.swap(ref x, ref y);

            Console.WriteLine("\n after swapping integers");
            Console.WriteLine($"x={x}\n y={y}");

            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.Now.AddDays(2);
            Console.WriteLine("\n Before swapping dates");
            Console.WriteLine($"date1={date1}\n date2={date2}");
            Helper2<DateTime>.swap(ref date1, ref date2);
            Console.WriteLine("\n after swapping dates");
            Console.WriteLine($"date1={date1}\n date2={date2}");

            Console.WriteLine("\nAdding two numbers of double types");
            Console.WriteLine($"The sum of doubles:{Helper2<double>.add(123.45, 123.56)}");
            Console.WriteLine($"The sum of ints:{Helper2<int>.add(123, 45)}");



            Console.ReadLine();




            Console.ReadLine();


        }
    }
}
