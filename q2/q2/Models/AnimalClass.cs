using System;

namespace q2
{
    public class Animal
    {
        private string name;
        private int HP;
        private int Age;
        public Animal() {
            Name = null;
            HealPoint = -1;
            Age1 = -1;
        }

        public void hpdown(int i)
        {
            HP -= i;
            if (HP <= 0)
            {
                Console.WriteLine("Him Die NOOOOOO! \n God pls NO!!!!");
            }
        }

        public Animal(string name,int hP, int age)
        {
            HP = hP;
            Age = age;
            Name = name;
        }
        public virtual string info()
        {
            return $"\nHP:{HealPoint}\nAge:{Age1}";

        }
        public int HealPoint { get => HP; set => HP = value; }
        public int Age1 { get => Age; set => Age = value; }
        public string Name { get => name; set => name = value; }
    }
}
