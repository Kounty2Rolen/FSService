//Quest 2
//Kounty_Rolen
//09.05.2019 Start
//09.05.2019 Finish

using System;

namespace q2
{
    class Program
    {
        static void Main()
        {
            System.Collections.Generic.List<Animal> animals = new System.Collections.Generic.List<Animal>();
            animals.Add(new Kesha(220,15,"Kesha Like a Boss"));
            animals.Add(new mycat(5,1,"Kid Anton"));
            animals[0].info();
            animals[1].info();

            Kesha kesha = new Kesha(12, 1,"Just Kesha");
            mycat anton = new mycat(25, 2, "anton");

            kesha.info();
            kesha.hpdown(3);
            kesha.Scream();

            anton.info();
            anton.meow();
            anton.Poop();
            anton.hpdown(25);

            Console.ReadKey();

        }
    }
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
        public virtual void info()
        {
            Console.WriteLine($"HP:{HealPoint}\nAge:{Age1}");

        }
        public int HealPoint { get => Age; set => Age = value; }
        public int Age1 { get => Age; set => Age = value; }
    }
    class Cats : Animal
    {
        private int paws=4;
        public Cats(int hP, int age) : base(hP, age)
        {

        }
        public void pawsdown()
        {
            Paws -= 1;

        }
        public override void info()
        {
            base.info();
            Console.WriteLine($"Paws:{Paws}");
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
        public override void info()
        {
            Console.WriteLine($"Name:{name}");
            base.info();
            Console.WriteLine("\n");
            
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
        private bool egg=false;
        public override void info()
        {
            base.info();
            Console.WriteLine($"Egg?:{Egg}");
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
        public override void info()
        {
            Console.WriteLine($"Name:{Name}");
            base.info();
            Console.WriteLine($"Injail?:{Injail}\n");
        }
        public void Scream()
        {

            Console.WriteLine($"{Name} Scream: AAAAAAAAAAAAAAAAAAAAAA!");
        }
    }
}
