using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product()
            {
                ProductId = 1, Name = "Shirt", Price = 599
            };


            //ProductDB db = new ProductDB(new FileLogger());
            ProductDB db = new ProductDB(new DatabaseLogger());
            db.Insert(product);





            Console.ReadLine();
        }
    }
}
