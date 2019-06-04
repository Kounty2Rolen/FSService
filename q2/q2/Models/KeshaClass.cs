using System;
using System.Data.SqlClient;

namespace q2.Models
{
    class Kesha : Birds
    {
        private string Class;
        public Kesha() :base(){

            Name = null;
            HealPoint = -1;
            Age1 = -1;
            Injail = false;
        }
        public Kesha(int hp, int age, string name, string Class = "Kesha") : base(hp, age, name)
        {
            this.Class = Class;
        }

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
