using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    //public class PlatiniumCustomer : Customer
    //{
    //    // Platinium Customer Specific Method
    //    public override void PrintTicket()
    //    {
    //        Console.WriteLine("Platinium Customer Ticket Printed");
    //    }
    //}



    // After Writting Interface

    public class PlatiniumCustomer : Customer, ICustomer
    {
        // Platinium Customer Specific Method
        public  void PrintTicket()
        {
            Console.WriteLine("Platinium Customer Ticket Printed");
        }
    }


}
