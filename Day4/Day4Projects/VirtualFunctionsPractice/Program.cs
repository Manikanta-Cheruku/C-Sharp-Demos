using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFunctionsPractice
{
    class BaseClass {

        virtual public void display()
        {
            Console.WriteLine("Base Class Display..");
        }
    }
    class subClass : BaseClass
    {
        public override void display()
        {
            Console.WriteLine("Sub Class Display..");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass obj;
            obj = new subClass();
            obj.display();
            Console.ReadLine();
        }
    }
}
