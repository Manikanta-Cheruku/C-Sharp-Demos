using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ArraysDemo
{

    public class Customer {
        public int customerid;

        public string customername;

    }

    class Program
    {
        static void Main(string[] args)
        {
            //infinite Array
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            //Normal Array
            int[] arr2 = new int[3] { 1, 3, 2 };

            //Empty Array
            int[] arr3 = new int[4];

            //string Array
            string[] names = new string[3] { "Ramu", "Shamu", "Mamu" };

            //chars Array
            char[] chars = new char[3] { 'a', 'b', 'c', };

            int[] a = new int[5]; //empty just declared not intialized

            int i, j, sum = 0;

            Console.WriteLine("Enter Values in Array");
            for (i = 0; i < a.Length; i++)
            {
                Console.Write($"Enter Element {i + 1}:");
                a[i] = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("\n Printing the Array");

                //  Console.WriteLine(a[i]);
            }
            print(a);

            Console.WriteLine("\n Sum of elements in Array..");

            for(i = 0; i < a.Length; i++)
            {
                sum = sum+ a[i];
            }
            Console.WriteLine($"Sum of the Array {sum}");

            //for Each loop to print 

            foreach(int ele in a)
            {
                Console.WriteLine($"\n Printing the elements using foreach Loop : {ele}");

            }

            for( i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"\n Printing the Modified Array {a[i] = a[i] * 3}");
            }

            Console.WriteLine("\n enter the element to be searched in arrray ");
            int ele1 = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == ele1)
                {
                    Console.WriteLine($"The element {ele1} is found at psosition {i + 1}");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine($"The element {ele1} is not there in array ");
            }



            Console.WriteLine("\n Sorting an array..using buble sort.");

            for (i = 0; i < a.Length - 1; i++)
            {
                for (j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp;
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nAfer sorting printing array ....");
            print(a);


            Customer[] custlist = new Customer[3];
            Console.WriteLine("\nEnter Customers..");
            for (i = 0; i < custlist.Length; i++)
            {
                Customer c = new Customer();
                Console.WriteLine($"Enter Customer {i + 1} details");
                Console.WriteLine("Enter customer id :");
                c.customerid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter customer name:");
                c.customername = Console.ReadLine();
                custlist[i] = c;
            }

            Console.WriteLine("\nPrinting customer array ...");
            foreach (Customer cust in custlist)
            {
                Console.WriteLine($"{cust.customerid}--{cust.customername}");
            }
            Console.ReadLine();

        }

        static void print(int[] arr1)
        {
            int i;
            Console.WriteLine("\n Printing the Array");

            for (i = 0; i < arr1.Length; i++)
            {

                Console.WriteLine(arr1[i]);
            }

        }
    }
}
