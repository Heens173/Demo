using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_SE1739_D2
{
    class Customer
    {
        private int id;
        //full properties
        public int CustomerId
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }


        public string CustomerName { get; set; } = "New customer";
        public void Print()
        {
            Console.WriteLine($"ID:{CustomerId}, Name: {CustomerName}");
        }
    }
   
        static void Main(string[] args)
        {
        Customer c = new Customer();
        c.CustomerId = 1000;
        Console.WriteLine($"ID:{c.CustomerId}, Name: {c.CustomerName}");
        c.CustomerId = 2000;
        c.CustomerName = "jakk";
        c.Print();
        Console.ReadLine();

    }

    
}
