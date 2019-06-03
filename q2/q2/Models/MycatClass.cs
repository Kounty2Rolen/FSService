using System;
using System.Data.SqlClient;


namespace q2.Models
{
    class mycat : Cats
    {
        private string Class;
        public void Serialize(SqlDataReader reader)
        {
            Name = reader.GetValue(1).ToString();
            HealPoint = Convert.ToInt32(reader.GetValue(2));
            Age1 = Convert.ToInt32(reader.GetValue(3));
        }
        public mycat(SqlDataReader reader) : base()
        {
            Serialize(reader);
        }
        public mycat(int hp, int age, string name, string Class = "Cats") : base(hp, age, name)
        {
            Name = name;
            this.Class = Class;
        }
        public override string info()
        {
            return $"Name:{name}" + base.info() + "\n";
        }
        private string name;
        public string Name { get => name; set => name = value; }

        public void Poop()
        {
            Console.WriteLine("{0} make poop", Name);
        }
        public void Serialize()
        {


        }
    }
}
