using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegateDemo
{

     class Program
    {
        public Program()
        {
            myevent = new mydelegate(testfunction);
        }

        public void testfunction()
        {
            Console.WriteLine("function is called ...");
        }

        public delegate void mydelegate();// it will point to test function
        public event mydelegate myevent;
        static void Main(string[] args)
        {
            Program pp = new Program();
            pp.myevent();
            new Program().myevent();// in one go u can do lie this 
            Console.ReadLine();
        }
    }
}
