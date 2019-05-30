using System;
using q2.Models;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace q2
{
    class Program
    {

        static void Main()
        {

            var db = new DB_Work.DBinit();
            db.openconn();
            var animals = new List<Animal>();
            animals.Add(new Kesha(220, 15, "Kesha Like a Boss", "Bird"));
            animals.Add(new mycat(5, 1, "Kid Anton", "Cat"));
            animals.Add(new mycat(5, 2, "Barsik", "Cat"));
            animals.Add(new mycat(12, 2, "Happy", "Cat"));
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.info());
                db.serialized(animal.Name, animal.HealPoint, animal.Age1, animal.Class1);
            }
            Console.ReadKey();
            Console.Clear();
            try
            {
                while (true)
                {
                    db.display();
                    Console.WriteLine("Input id:\n Input 0 if you want GOTO exit");
                    int id = Convert.ToInt32(Console.ReadLine());
                    if (!Convert.ToBoolean(id))
                    {
                        break;
                    }

                    var result = db.deserialized(id);
                    switch (result[4])
                    {
                        case "Bird": animals.Add(new Kesha(Convert.ToInt32(result[2]), Convert.ToInt32(result[3]), result[1], result[4])); break;
                        case "Cat": animals.Add(new mycat(Convert.ToInt32(result[2]), Convert.ToInt32(result[3]), result[1], result[4])); break;
                    }
                    break;

                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
            }

            db.closeconn();
        }
    }
}
