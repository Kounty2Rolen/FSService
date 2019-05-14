using System;
using System.Collections.Generic;
using System.Text;

namespace q2.Models
{
    class Kesha : Birds
    {
        public Kesha(int hp, int age, string name) : base(hp, age)
        {
            Name = name;
        }
        private string name;
        public string Name { get => name; set => name = value; }
        private bool injail;

        public bool Injail { get => injail; set => injail = value; }
        public override string info()
        {
            return $"Name:{Name}" + base.info() + $"Injail?:{Injail}\n";

        }
        public void Scream()
        {

            Console.WriteLine($"{Name} Scream: AAAAAAAAAAAAAAAAAAAAAA!");
        }
    }
}
