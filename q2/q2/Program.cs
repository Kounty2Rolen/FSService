using q2.DB_Work;
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n\n" + ex.StackTrace);
            }
            //var animals = new List<Animal>();
            //animals.Add(new Kesha(220, 15, "Kesha Like a Boss", "Bird"));
            //animals.Add(new mycat(5, 1, "Kid Anton", "Cat"));
            //animals.Add(new mycat(5, 2, "Barsik", "Cat"));
            //animals.Add(new mycat(12, 2, "Happy", "Cat"));
            //foreach (Animal my_skills_are_from_2_labs in animals)
            //{
            //    Console.WriteLine(my_skills_are_from_2_labs.info());
            //}
            //Console.ReadKey();
            //Console.Clear();
        }
    }
}
