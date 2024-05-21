using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependancy_Injection
{
    //high level module
    public class TrainerBL 
    {
        private ITrainerDb _db;

        //DI using Constructor
        public TrainerBL(ITrainerDb db)  // so here      db=new TrainerDb()
        {
            _db = db;
        }



        //// DI using Property
        //public ITrainerDb Dependency
        //{
        //    set
        //    {
        //        _db = value;
        //    }
        //}



        ////DI using Method

        //public void SetDepedency(ITrainerDb db)
        //{
        //    _db = db;
        //}





        public void Insert()
        {
            //TrainerDb db = new TrainerDb();
            //db.Insert();
            _db.Insert();
        }

    }
}
