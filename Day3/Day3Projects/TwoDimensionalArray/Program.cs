using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j,sum=0;
            Console.WriteLine("\n------------------------");
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write($"{i}  ");

                }
                Console.WriteLine();
            }
            Console.WriteLine("\n------------------------");

            Console.WriteLine("\n Printing 3 by 3 Matrix");
            int[,] a = new int[3, 3]; // 2 d Array  l,b
            int[,,] aa = new int[3, 3, 3]; //3 d Array l,b,h
            Console.WriteLine("Enter Elements in 2d Array");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine($"enter [{i + 1},{j + 1}] element:");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n Printing an Array");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write($"{a[i, j]}   ");

                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\n sum of elements in matrix");
            for (i = 0; i < 3; i++)
            {
                sum = sum + a[i, j];
            }
            Console.WriteLine($"\n The sum is {sum}")
            Console.ReadLine();
        }
    }
}
