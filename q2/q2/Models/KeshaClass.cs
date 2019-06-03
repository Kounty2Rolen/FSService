using System;
using System.Data.SqlClient;

namespace q2.Models
{
    class Kesha : Birds
    {
        private string Class;
        public void Serialize(SqlDataReader reader)
        {
            Name = reader.GetValue(1).ToString();
            HealPoint = Convert.ToInt32(reader.GetValue(2));
            Age1 = Convert.ToInt32(reader.GetValue(3));
        }
        public Kesha(SqlDataReader reader) : base()
        {
            Serialize(reader);
        }
        public Kesha(int hp, int age, string name, string Class = "Kesha") : base(hp, age, name)
        {
            Name = name;
            this.Class = Class;
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
