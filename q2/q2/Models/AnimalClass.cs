using System;

namespace q2
{
    public class Animal
    {
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

        public Animal(int hP, int age)
        {
            HP = hP;
            Age = age;
        }
        public virtual string info()
        {
            return $"HP:{HealPoint}\nAge:{Age1}";

        }
        public int HealPoint { get => Age; set => Age = value; }
        public int Age1 { get => Age; set => Age = value; }
    }
}
