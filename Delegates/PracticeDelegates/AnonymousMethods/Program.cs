using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    public delegate string GreetDelegate(string name);
    class Program
    {
        public static string Greetings(string name)
        {
            return "Hello" +" "+ name+" "+ "a very good morning!";
        }
        static void Main(string[] args)
        {
            GreetDelegate obj = new GreetDelegate(Greetings);

          string str =   obj.Invoke("Manikanta");
            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
