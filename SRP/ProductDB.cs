using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class ProductDB 
    {
        ILogger _log;

        public ProductDB(ILogger log)
        {
            _log = log;
        }

        public void Insert(Product product)
        {
            

            try
            {
                // ADO.NET code to insert data

            }
            catch (Exception ex)
            {
                //  Log errors details to text file
                string message = $"Error Occured : {ex.Message} at {DateTime.Now} \n";

                ////File.AppendAllText(@" Data\errors.text ", message);
                //FileLogger log = new FileLogger();
                //log.log(message);




                ///  --->  for DIP

                _log.Log(message);
                
            }

        }


    }
}
