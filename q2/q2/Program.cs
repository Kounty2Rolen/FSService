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
                DBinit db = new DBinit();
                db.GetValue();
                foreach (Animal a in db.GetValue())
                {
                    Console.WriteLine(a.info());
                }
                db.closeconn();
                Console.ReadKey();
                
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }
    }
}
