using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    class Customer
    {

        private int customerid;
        private string customername;

        //public void setcustomerid(int id1)
        //{
        //    customerid = id1;
        //}

        //public int getcustomerid()
        //{
        //    return customerid;

        //}

        //public void setcustomername(string name)
        //{
        //    customername = name;
        //}

        //public string getcustomername()
        //{
        //    return customername;
        //}

        //public int CUSTID
        //{
        //    set {
        //        customerid = value;
        //    }
        //    get
        //    {
        //        return customerid;
        //    }
        //}

        //public string CUSTNAME
        //{
        //    set
        //    {
        //        customername = value;
        //    }
        //    get
        //    {
        //        return customername;
        //    }
        //}

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
                //Customer cc = new Customer();
                ////cc.setcustomerid(1001);
                //Console.WriteLine("\n Enter customer id");
                //cc.setcustomerid(Convert.ToInt32(Console.ReadLine()));
                //Console.WriteLine("\n Enter customer name");
                //cc.setcustomername(Console.ReadLine());
                //Console.WriteLine($"{cc.getcustomerid()}--{cc.getcustomername()}");
                //Console.ReadLine();

                //Customer cc1 = new Customer();
                //Console.WriteLine("\n Enter CUSTID");
                //cc1.CUSTID = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("\nEnter CUSTNAME");
                //cc1.CUSTNAME = Console.ReadLine();
                //Console.WriteLine($"{cc1.CUSTID}--{cc1.CUSTNAME}");
                //Console.ReadLine();



            Customer cc = new Customer();
            cc.CUSTID = 13541;
            cc.CUSTNAME = "sudhaMurthy";
            cc.displaycustomer();


            Console.ReadLine();
                //Console.WriteLine($"{cc2.CUSTID}--{cc2.CUSTNAME}");

            }

           
    }
    
}
