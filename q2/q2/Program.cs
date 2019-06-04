using q2.DB_Work;
using q2.Models;
using System;
using System.Collections.Generic;


namespace q2
{
    class Program
    {

        static void Main()
        {
            try
            {
                List<Animal> my_skills_are_from_2_labs = new List<Animal>();
                DBinit db = new DBinit();
                db.GetValue(my_skills_are_from_2_labs);
                foreach (Animal a in my_skills_are_from_2_labs)
                {
                    Console.WriteLine(a.info());
                }
                db.closeconn();
                Console.ReadKey();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n\n" + ex.StackTrace);
            }
           
        }
    }
}
