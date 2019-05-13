
using System;
using System.Collections.Generic;

namespace q2
{
    class Program
    {
        static void Main()
        {
            var animals = new List<Animal>();
            animals.Add(new Kesha(220, 15, "Kesha Like a Boss"));
            animals.Add(new mycat(5, 1, "Kid Anton"));
            animals.Add(new mycat(5, 2, "Barsik"));
            animals.Add(new mycat(12, 2, "Happy"));
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.info());
            }
            Console.ReadKey();

        }
    }
}
