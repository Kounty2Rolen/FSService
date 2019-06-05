using q2.DB_Work;
using q2.Models;
using System;
using System.Data.SqlClient;


namespace q2
{
    class Program
    {

        static void Main()
        {
            try
            {
                var db = new DBinit();
                db.GetAllRecords().ForEach(x => { Console.WriteLine(x.info()); });
                db.closeconn();
                Console.ReadKey();
                
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}


        }
    }
}
