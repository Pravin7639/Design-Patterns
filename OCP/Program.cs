using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            //SilverCustomer sc = new SilverCustomer();
            //sc.ShowsTimings();

            //GoldCustomer gc = new GoldCustomer();
            //gc.ShowsTimings();

            //PlatiniumCustomer pc = new PlatiniumCustomer();
            //pc.ShowsTimings();


            //List<Customer> customers = new List<Customer>();
            //customers.Add(new SilverCustomer());
            //customers.Add(new GoldCustomer());
            //customers.Add(new PlatiniumCustomer());
            //customers.Add(new Enquiry());



            //foreach (var item in customers)
            //{
            //    item.ShowsTimings();
            //}



            List<ICustomer> customers = new List<ICustomer>();
            customers.Add(new SilverCustomer());
            customers.Add(new GoldCustomer());
            customers.Add(new PlatiniumCustomer());
           


            foreach (var item in customers)
            {
                item.PrintTicket();
            }



          

            Console.ReadLine();
        }
    }
}
