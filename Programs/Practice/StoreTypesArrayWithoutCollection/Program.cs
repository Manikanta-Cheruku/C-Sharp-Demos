using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreTypesArrayWithoutCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] arr = new object[3];
            arr[0] = 1;
            arr[1] = "Mani";
            arr[2] = 5.10;
            //arr[3] = true;

            foreach (object o in arr)
            {
                Console.WriteLine(o);
            }
        }
    }
}
