using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Dependancy_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            //TrainerBL bl = new TrainerBL();        // normal
            //bl.Insert();


            //TrainerBL bl = new TrainerBL(new TrainerDb());   // DI using Constructor (most used)
            //bl.Insert();


            //TrainerBL bl = new TrainerBL();                     //DI Using Property
            //bl.Dependency = new TrainerDb();
            //bl.Insert();


            //TrainerBL bl = new TrainerBL();                      // DI using Method
            //bl.SetDepedency(new TrainerDb());
            //bl.Insert();






       
       
            var container = new UnityContainer();      //////// Using IoC -->Inversion Of Control

            //type register
            container.RegisterType<ITrainerDb, TrainerDb>();

            //resolve

            TrainerBL bl = container.Resolve<TrainerBL>();

            bl.Insert();





            Console.ReadLine();
        }
    }
}
