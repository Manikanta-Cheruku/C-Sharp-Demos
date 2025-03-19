using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/** Lambda expression : 
-------------------------
some times u want to execute the function in a single line when u think that inside that function lot of code is not there then i will make that function run using lambda expression and this is very much used in MVC programming and linq programming 


Q)write a lambda expression for the below function 


   public void add(int x, int y) 
  {
 
   console.writeline("The sum is "+(x+y));
  
   }


   (  x,y  )=>   console.writeline("The sum is "+(x+y)) };
 

 **/
namespace DelegateDemoUsingLambdaExp
{
     class Program
    {
        //public static void add(int x, int y)
        //{
        //    Console.WriteLine($"The sum is :{x + y}");
        //}

        //public static int substract(int x, int y)
        //{
        //    return (x - y);
        //}

        //public static int multiply(int x, int y)
        //{
        //    return (x * y);
        //}

        public delegate void mydelegate(int x, int y);
        public delegate int mydelegate2(int x, int y);
        static void Main(string[] args)
        {
            mydelegate mm1 = (x, y) => { Console.WriteLine($"The sum is :{x + y}"); };
            mm1(12, 4);
            mydelegate2 mm2 = (x, y) => { return (x - y); };
            Console.WriteLine($"The substractions : {mm2.Invoke(12, 4)}");
            mm2 += (x, y) => { return (x * y); };
            Console.WriteLine($"The multiplication : {mm2.Invoke(12, 4)}");
            Console.ReadLine();
        }
    }
}
