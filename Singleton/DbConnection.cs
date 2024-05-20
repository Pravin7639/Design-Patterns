using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class DbConnection
    {
        private static DbConnection obj = null;            //static property

        private static object o = new object();

        private static int count = 1;

        private DbConnection() { }                        // private constructor

        public static DbConnection Instance
        {
            get
            {
                        if (count<=5)
                        {
                            obj = new DbConnection();
                               count++;
                        }
                        else
                        {
                            Console.WriteLine("Only 5 Object Creation is allowed.");
                        }
                            return obj;

            }
        }

    }
}
