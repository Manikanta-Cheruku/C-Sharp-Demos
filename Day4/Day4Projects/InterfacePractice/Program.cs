using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    interface A {
        void area(int s);

    }
    interface B { 
        void area(int x,int y);
    }
    //i can inherit multiple interfaces can inherit only one class
    class newShape : A, B
    {
        public void area(int s)
        {
            Console.WriteLine($"Area of Square is : {s * s}");
        }

        public void area(int x, int y)
        {
            Console.WriteLine($"Area of rectangle is :{x * y}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            A obj;
            obj = new newShape();
            obj.area(15);
            B obj1;
            obj1 = new newShape();
            obj1.area(12, 10);
        }
    }
}
