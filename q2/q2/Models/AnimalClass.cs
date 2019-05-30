using System;

namespace q2
{
    public class Animal
    {
        private string Class;
        public Animal() { }
        private string name;
        private int HP;
        private int Age;
        public void hpdown(int i)
        {
            HP -= i;
            if (HP <= 0)
            {
                Console.WriteLine("Him Die NOOOOOO! \n God pls NO!!!!");
            }
        }

        public Animal(string name,int hP, int age, string Class)
        {
            HP = hP;
            Age = age;
            Class1 = Class;
            Name = name;
        }
        public virtual string info()
        {
            return $"HP:{HealPoint}\nAge:{Age1}";

        }
        public int HealPoint { get => HP; set => HP = value; }
        public int Age1 { get => Age; set => Age = value; }
        public string Class1 { get => Class; set => Class = value; }
        public string Name { get => name; set => name = value; }
    }
}
