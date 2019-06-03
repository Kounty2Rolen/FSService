﻿namespace q2.Models
{
    class Birds : Animal
    {
        public Birds() : base() { }
        public Birds(int hp, int age, string name) : base(name, hp, age)
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
