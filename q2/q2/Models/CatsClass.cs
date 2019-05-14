using System;
using System.Collections.Generic;
using System.Text;

namespace q2.Models
{
    public class Cats : Animal
    {
        private int paws = 4;
        public Cats(int hP, int age) : base(hP, age)
        {

        }
        public void pawsdown()
        {
            Paws -= 1;

        }
        public override string info()
        {
            return base.info() + $"Paws:{Paws}";
        }
        public int Paws { get => paws; set => paws = value; }

        public void meow() { Console.WriteLine("meow"); }
    }
}
