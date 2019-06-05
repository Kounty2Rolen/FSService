using System;

namespace q2.Models
{
    public class Cats : Animal
    {
        public string kingdom = "CATS";
        public Cats() : base()
        {
        }
        public Cats(int hP, int age, string name) : base(name, hP, age)
        {

        }
        public override string info()
        {
            return base.info();
        }

        public void meow() { Console.WriteLine("meow"); }
    }
}
