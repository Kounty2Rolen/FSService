using System;

namespace q2.Models
{
    public class Cats : Animal
    {
        public string kingdom = "CATS";
        public Cats() : base()
        {
            Name = null;
            HealPoint = -1;
            Age1 = -1;

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
