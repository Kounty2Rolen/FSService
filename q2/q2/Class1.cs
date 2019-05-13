using System;

namespace q2
{
    class Animal
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
    class Cats : Animal
    {
        private int paws = 4;
        public Cats(int hP, int age) : base(hP, age)
        {

        }
        public void pawsdown()
        {
            Paws -= 1;

        }
        public override string info()
        {
            return base.info() + $"Paws:{Paws}";
        }
        public int Paws { get => paws; set => paws = value; }

        public void meow() { Console.WriteLine("meow"); }
    }
    class mycat : Cats
    {
        public mycat(int hp, int age, string name) : base(hp, age)
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
    class Birds : Animal
    {
        public Birds(int hp, int age) : base(hp, age)
        {

        }
        private bool egg = false;
        public override string info()
        {
            return base.info() + $"\nEgg?:{Egg}\n";
        }
        public bool Egg { get => egg; set => egg = value; }
    }
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
