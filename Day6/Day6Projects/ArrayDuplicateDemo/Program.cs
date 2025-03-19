using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDuplicateDemo
{

    class Customer
    {
        public int CustomerID { set; get; }
        public string CustomerName { set; get; }

        public static List<Customer> retrive()
        {
            List<Customer> list = new List<Customer>()
            {
              new Customer{CustomerID=101,CustomerName="sita"},
              new Customer{CustomerID=102,CustomerName="suresh"},
              new Customer{CustomerID=103,CustomerName="mahesh"}

            };
            return list;
        }

        public static void PrintCustomer(List<Customer> clist)
        {
            Console.WriteLine("\ndisplaying cusomters");
            foreach (Customer cust in clist)
            {
                Console.WriteLine($"{cust.CustomerID}--{cust.CustomerName}");
            }
        }
        public static void insertcustomer(Customer customer, List<Customer> clist)
        {
            clist.Add(customer);
        }
        public static Customer findcustomer(int custid1, List<Customer> clist)
        {
            Customer customerfound = null;
            foreach (Customer c in clist)
            {
                if (c.CustomerID == custid1)
                {
                    customerfound = c;
                    break;
                }

            }
            return customerfound;

        }


        public static void updatecustomer(int cid, List<Customer> clist)
        {
            for (int i = 0; i < clist.Count; i++)
            {
                if (clist[i].CustomerID == cid)
                {
                    Console.WriteLine("enter new name");
                    string newname = Console.ReadLine();
                    clist[i].CustomerName = newname;
                }
            }
        }

        public static void deletecustomer(int cid, List<Customer> clist)
        {
            for (int i = 0; i < clist.Count; i++)
            {
                if (clist[i].CustomerID == cid)
                {
                    clist.RemoveAt(i);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int[] aa = new int[] { 12, 33, 44, 5, 89, 56, 71, 90, 12, 44 };
            //remove  duplicate elements from the array aa and give it to me by keeping it result list

            List<int> result = new List<int>();

            foreach (int number in aa)
            {
                bool found = false;
                foreach (int resultitem in result)
                {
                    if (resultitem == number)
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    result.Add(number);
                }
            }
            Console.WriteLine("\n after removing duplicate elements ..");
            foreach (int k in result)
            {
                Console.Write($"{k}  ");
            }
            List<Customer> custlist = Customer.retrive();
            Customer.PrintCustomer(custlist);
            Console.WriteLine("\n enter the customer to be added in the list");
            Customer c4 = new Customer()
            {
                CustomerID = 104,
                CustomerName = "rajesh"
            };
            Customer.insertcustomer(c4, custlist);
            Customer.PrintCustomer(custlist);

            Console.WriteLine("\n enter the customer id to find");
            int custid2 = Convert.ToInt32(Console.ReadLine());
            Customer customergot = Customer.findcustomer(custid2, custlist);
            if (customergot != null)
            {
                Console.WriteLine($"The cusotmer wit id {customergot.CustomerID} is having name {customergot.CustomerName}");
            }
            else
            {
                Console.WriteLine("\n the customer is not found ");
            }

              Console.WriteLine("\n enter the id of customer whos name u want to change ");
            int customerid2= Convert.ToInt32(Console.ReadLine());
            Customer.updatecustomer(customerid2,custlist);
            Customer.PrintCustomer(custlist);
            Console.WriteLine("\n enter the id of customer whos name u want to delete ");
            int customerid3 = Convert.ToInt32(Console.ReadLine());
            Customer.deletecustomer(customerid2, custlist);
            Customer.PrintCustomer(custlist);

            Console.ReadLine();
        }
    }
}
