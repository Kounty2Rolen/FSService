using System;
using System.Collections.Generic;
using System.Text;

namespace q2.Models
{
    class Birds : Animal
    {
        public string kingdom = "ANIMALS";
        public Birds() : base() { }
        public Birds(int hp, int age,string Class,string name) : base(name,hp, age,Class)
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
