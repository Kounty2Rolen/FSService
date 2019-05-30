using System;
using System.Collections.Generic;
using System.Text;

namespace q2.Models
{
    class mycat : Cats
    {
        public mycat():base()
        {

        }
        public mycat(int hp, int age, string name,string Class) : base(hp, age,Class,name)
        {
            Name = name;
        }
        public override string info()
        {
            return $"Name:{name}\n" + base.info() + "\n";
        }
        private string name;
        public string Name { get => name; set => name = value; }

        public void Poop()
        {
            Console.WriteLine("{0} make poop", Name);
        }
    }
}
