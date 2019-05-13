using System;
using System.Collections.Generic;
using System.Text;

namespace q2.Models
{
    class Birds : Animal
    {
        public Birds(int hp, int age) : base(hp, age)
        {

        }
        private bool egg = false;
        public override string info()
        {
            return base.info() + $"\nEgg?:{Egg}\n";
        }
        public bool Egg { get => egg; set => egg = value; }
    }
}
