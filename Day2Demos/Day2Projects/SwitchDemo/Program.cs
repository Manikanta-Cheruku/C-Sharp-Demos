//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SwitchDemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int a, b, c, choice;
//            Console.WriteLine("Enter values in a and b");
//            a = Convert.ToInt32(Console.ReadLine());
//            b = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("\n enter your Choice ...");
//            Console.WriteLine("***************************");
//            Console.WriteLine("1.Addition...");
//            Console.WriteLine("2.Subtraction...");
//            Console.WriteLine("3.Multiplication...");
//            Console.WriteLine("4.Division...");
//            choice = Convert.ToInt32(Console.ReadLine());

//            switch (choice)
//            {
//                case 1:
//                    c = a + b;
//                    Console.WriteLine($"The sum is {c}");
//                    break;
//                case 2:
//                    c = (a > b) ? (a - b) : (b - a);
//                    Console.WriteLine($"The subtraction is {c}");
//                    break;
//                case 3:
//                    c = a * b;
//                    Console.WriteLine($"The Multiplication is {c}");
//                    break;
//                case 4:
//                    c = a / b;
//                    Console.WriteLine($"The division is {c}");
//                    break;
//                default:
//                    Console.WriteLine("Enter values between 1 to 4 only...");
//                    break;
//                    Console.ReadLine();
//            }
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;// choice;
            char choice2;
            Console.WriteLine("Enter values in a and b ..");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("\n enter your choice ....");
                Console.WriteLine("***************************");
                Console.WriteLine("A.Addition...");
                Console.WriteLine("B.Substraction ...");
                Console.WriteLine("C.Multiplication ...");
                Console.WriteLine("D.Division ...");
                Console.WriteLine("E.All Actions ");
                //choice = Convert.ToInt32(Console.ReadLine());
                choice2 = Convert.ToChar(Console.ReadLine());

                switch (choice2)
                {

                    case 'A':
                    case 'a':
                        c = a + b;
                        Console.WriteLine($"The sum is {c} ");
                        break;
                    case 'B':
                        c = (a > b) ? (a - b) : (b - a);
                        Console.WriteLine($"The substraction is {c}");
                        break;

                    case 'C':
                        c = a * b;
                        Console.WriteLine($"The Multiplication  is {c} ");
                        break;
                    case 'D':
                        c = a / b;
                        Console.WriteLine($"The division is {c}");
                        break;

                    case 'E':
                        c = a + b;
                        Console.WriteLine($"The sum is {c} ");
                        c = (a > b) ? (a - b) : (b - a);
                        Console.WriteLine($"The substraction is {c}");
                        c = a * b;
                        Console.WriteLine($"The Multiplication  is {c} ");
                        c = a / b;
                        Console.WriteLine($"The division is {c}");


                        break;

                    default:
                        Console.WriteLine("Enter values between A to B  only...");
                        break;
                }
                Console.WriteLine("\ndo you want to continue<y/n>?");
                if (Console.ReadLine() != "y")
                {
                    break;
                }

            } while (true);

            Console.ReadLine();
        }
    }



}