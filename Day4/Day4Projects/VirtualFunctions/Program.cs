//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.ConstrainedExecution;
//using System.Text;
//using System.Threading.Tasks;

//namespace VirtualFunctions
//{
//    class BaseClass
//    {
//        public void display()
//        {
//            Console.WriteLine("Base class display...");
//        }
//    }
//    class SubClass : BaseClass
//    {
//        public void display()
//        {
//            Console.WriteLine("Sub class display...");
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            BaseClass bobj;
//            bobj = new SubClass();
//            bobj.display();
//            Console.ReadLine();
//        }
//    }
//}
////as per above logic sub clas code should come but base class code is shown as it base class is hiding the funcitonlity of sub class so base class function make it virtual 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;



namespace VirtualFunctions
{
    class BaseClass
    {
        public virtual void display() //virtuallll 
        {
            Console.WriteLine("Base class display...");
        }
    }
    class SubClass : BaseClass
    {
        public override void display() //Override
        {
            Console.WriteLine("Sub class display...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bobj;
            bobj = new SubClass();
            bobj.display();
            Console.ReadLine();

        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Virtualfunctions
//{
//    class BaseClass
//    {
//        public virtual void display()
//        {
//            Console.WriteLine("Base class display...");
//        }
//    }
//    class SubClass : BaseClass
//    {
//        //public override void display()
//        //{
//        //    Console.WriteLine("Sub class display...");
//        //}
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            BaseClass bobj;
//            bobj = new SubClass();
//            bobj.display();
//            Console.ReadLine();

//        }
//    }
//}

//above i commneted the code i am not getting error same thing you will get error in abstract class okay means u have to implment it 