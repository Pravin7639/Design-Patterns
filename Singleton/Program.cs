using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            DbConnection db1 = DbConnection.Instance;
            DbConnection db2 = DbConnection.Instance;
            DbConnection db3 = DbConnection.Instance;
            DbConnection db4 = DbConnection.Instance;
            DbConnection db5 = DbConnection.Instance;
            //DbConnection db6 = DbConnection.Instance;   // not poassible

            //DbConnection db = new DbConnection();  // now this is not possible because of private keyword

            if (db1.Equals(db2) && db2.Equals(db3))
            {
                Console.WriteLine("db1, db2 and db3 are equal.");
            }
            else
            {
                Console.WriteLine("db1, db2 and db3 are not equal.");
            }


            Console.ReadLine();
        }
    }
}
