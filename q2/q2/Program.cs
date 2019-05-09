using System;

namespace q2
{
    class Program
    {
        static void Main()
        {
            Kesha kesha = new Kesha(12, 1);
            mycat anton = new mycat(25, 2, "anton");
            kesha.hpdown(3);
            anton.meow();
            anton.Poop();
            anton.hpdown(25);
            kesha.Scream();
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

        public int HealPoint { get => Age; set => Age = value; }
        public int Age1 { get => Age; set => Age = value; }
    }
    class Cats : Animal
    {
        private int paws;
        public Cats(int hP, int age) : base(hP, age)
        {

        }
        public void pawsdown()
        {
            Paws -= 1;

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
        private bool egg;

        public bool Egg { get => egg; set => egg = value; }
    }
    class Kesha : Birds
    {
        public Kesha(int hp, int age) : base(hp, age)
        {

        }
        private bool injail;

        public bool Injail { get => injail; set => injail = value; }

        public void Scream()
        {

            Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAA!");
        }
    }
}
