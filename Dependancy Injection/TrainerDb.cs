using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependancy_Injection
{
    //low level module
    public class TrainerDb : ITrainerDb
    {
        //CRUD methods for Trainer Table
        //SQL Data Provider
        public void Insert()
        {
            Console.WriteLine("Trainer Inserted Successfully.");
        }

    }
}
