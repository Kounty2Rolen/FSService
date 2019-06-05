using System;
using System.Data.SqlClient;

namespace q2.Models
{
    class Kesha : Birds
    {
        private string Class;
        public Kesha(SqlDataReader reader) : base()
        {

            Name = null;
            HealPoint = -1;
            Age1 = -1;
            Injail = false;
            Serialize(reader);
        }
        public override void Serialize(SqlDataReader reader)
        {
            base.Serialize(reader);
            if (reader["injail"] != null)
                Injail = Convert.ToBoolean(reader["injail"]);
        }
        public Kesha(int hp, int age, string name, bool Injail, string Class = "Kesha") : base(hp, age, name)
        {
            this.Class = Class;
        }

        public override string info()
        {
            return $"Name:{Name}" + base.info() + $"Injail?:{Injail}\n";

        }
        private bool injail = false;

        public bool Injail { get => injail; set => injail = value; }
        public void Scream()
        {

            Console.WriteLine($"{Name} Scream: AAAAAAAAAAAAAAAAAAAAAA!");
        }
    }
}
