using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo01
{
    class Customer
    {
        private int customerid;
        private string customername;

        public int CUSTID
        {
            set
            {
                customerid = value;
            }

        }

        public string CUSTNAME
        {
            set
            {
                customername = value;
            }
        }

        public void displaycustomer()
        {
            Console.WriteLine($"{customerid}--{customername}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer cc = new Customer();
            cc.CUSTID = 1001;
            cc.CUSTNAME = "sudha";
            cc.displaycustomer();

            Console.ReadLine();
        }
    }
}
