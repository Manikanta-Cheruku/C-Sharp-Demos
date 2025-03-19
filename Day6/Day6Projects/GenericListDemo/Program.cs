using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<int> numbers2 = new List<int>();
            numbers2.Add(12);
            numbers2.AddRange(new int[] { 12, 45, 67, 89, 100 });
            Console.WriteLine("\n displaying numbers ");
            foreach (int number in numbers)
            {

                Console.Write($"{number}  ");

            }
            Console.WriteLine("\n displaying numbers2");
            foreach (int num in numbers2)
            {

                Console.Write($"{num}  ");
            }

            List<string> boysnames = new List<string>() { "kiran", "karthik", "mahesh", "suresh" };
            var girlnames = new List<string>();
            girlnames.Add("sudha");
            girlnames.AddRange(new string[] { "sita", "shanthi", "priya", "suman" });

            Console.WriteLine("\n\n displaying boys ");
            foreach (string boy in boysnames)
            {

                Console.WriteLine($"{boy}");

            }
            Console.WriteLine("\n displaying girls");
            foreach (string girl in girlnames)
            {

                Console.WriteLine($"{girl}");
            }
            Console.ReadLine();
        }
    }
}
