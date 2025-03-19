using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace AccessSpecifiersDemo
{

    class abcd {

        private int a;
        public void seta(int k)
        {
            a = k;
        }
        public int geta() { return a; }
        public int b = 2;
        protected int c = 3;
    
    
    
    }

    class Program :   Class1//abcd   //I'm doing Inheritance
    {
        static void Main(string[] args)
        {
            abcd obj = new abcd();
            Program pp = new Program();

            Console.WriteLine($"{ obj.b}"); //i can touch b and print it
            //Console.WriteLine($"{pp.b}"); // sub class can access b and print
            //Console.WriteLine($"{pp.c}");// sub class obj can touch c and print
            //obj.a not possible
            //obj.c also not possible
            obj.seta(1);
            Console.WriteLine(obj.geta());

            //Class1 c1 = new Class1();
            //Console.WriteLine(c1.d);
            //We Cannot Access 

            Console.WriteLine($"This is accesible from another assembly  {pp.d}");

            

        }
    }
}
