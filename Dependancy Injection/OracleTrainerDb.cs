using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependancy_Injection
{
    public class OracleTrainerDb : ITrainerDb
    {
        public void Insert()
        {
            Console.WriteLine("Trainer Inserted Successfully in Oracle DB.");
        }
    }
}
