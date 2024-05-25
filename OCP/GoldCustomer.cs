using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    //public class GoldCustomer : Customer
    //{
    //    public override void PrintTicket()
    //    {
    //        Console.WriteLine("Gold Customer Ticket Printed");
    //    }
    //}




    // After Writting Interface

    public class GoldCustomer : Customer, ICustomer
    {
        public  void PrintTicket()
        {
            Console.WriteLine("Gold Customer Ticket Printed");
        }
    }



}
