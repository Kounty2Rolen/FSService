using System;
using System.Collections.Generic;
using System.Text;

namespace q2.Models
{
    public class Cats : Animal
    {
        public string kingdom = "CATS";
        public Cats() : base() { }
        private int paws = 4;
        public Cats(int hP, int age,string name) : base(name,hP, age)
        {

        }
        public void pawsdown()
        {
            Paws -= 1;

        }
        public override string info()
        {
            return base.info() + $"\nPaws:{Paws}";
        }
        public int Paws { get => paws; set => paws = value; }

        public void meow() { Console.WriteLine("meow"); }
    }
}
