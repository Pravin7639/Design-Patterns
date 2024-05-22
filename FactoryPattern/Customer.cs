using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Customer
    {
        public string Name { get; set; }

        public Customer()
        {
            Name = "Normel Customer";
        }
    }


    public class SilverCustomer : Customer
    {
        
        public SilverCustomer()
        {
            Name = "SilverCustomer Customer";
        }
    }


    public class GoldCustomer : Customer
    {
        public GoldCustomer()
        {
            Name = "GoldCustomer Customer";
        }
    }


    public class PlatiniumCustomer : Customer
    {
        public PlatiniumCustomer()
        {
            Name = "PlatiniumCustomer Customer";
        }
    }



}
