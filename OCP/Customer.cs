using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public abstract class Customer
    {

        public void ShowsTimings()
        {
            Console.WriteLine("*** All Todays Shows ***");
        }


        //public abstract void PrintTicket();

    }

    public interface ICustomer
    {
          void PrintTicket();

    }

    public interface ICustomerNew : ICustomer
    {
        void FreeFood();

    }

}
