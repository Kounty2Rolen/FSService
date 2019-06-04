using System;
using System.Data.SqlClient;


namespace q2.Models
{
    class mycat : Cats
    {
        private string Class;
        public mycat() : base()
        {
            Name = null;
            HealPoint = -1;
            Age1 = -1;
        }
        public mycat(int hp, int age, string name, string Class = "Cats") : base(hp, age, name)
        {
            this.Class = Class;
        }
        public override string info()
        {
            return $"Name:{Name}" + base.info() + "\n";
        }
        public void Poop()
        {
            Console.WriteLine("{0} make poop", Name);
        }
    }
}
