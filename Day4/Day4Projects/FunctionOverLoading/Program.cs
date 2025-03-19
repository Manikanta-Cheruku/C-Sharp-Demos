using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverLoading
{
    class abcd
    {
        public void add(int x, int y)
        {
            Console.WriteLine($"The sum is {x + y}");
        }


        public double add(int x, float y, double kk)
        {
            return (x + y + kk);
        }

        public decimal add(int x, double jj, decimal cc)
        {
            return (x + Convert.ToDecimal(jj) + cc);
        }
    }

    class cde : abcd
    {
        public void add(int x, char ch)
        {
            Console.WriteLine($"The sum is {x + ch}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            cde cde = new cde();
            cde.add(12, 34);
            cde.add(12, 'A');
            Console.WriteLine($"The sum is {cde.add(12, 345.34, 234.35M)}");
            Console.WriteLine($"The sum is {cde.add(13, 34.5F, 678.34M)}");
            Console.ReadLine();
        }
    }
}
