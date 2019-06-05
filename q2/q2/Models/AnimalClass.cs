using System;
using System.Data.SqlClient;

namespace q2.Models
{
    /// <summary>
    /// Класс-родитель "Животные"
    /// </summary>
    public class Animal
    {
        private string name;
        private int HP;
        private int Age;
        /// <summary>
        /// Метод для сериализации обьектов из sqldatareader
        /// </summary>
        /// <param name="reader">sqldatareader</param>
        public virtual void Serialize(SqlDataReader reader)
        {
                Name = reader["Name"].ToString();
                HealPoint = Convert.ToInt32(reader["HP"]);
                Age1 = Convert.ToInt32(reader["age"]);
        }
        /// <summary>
        /// Конструктор по умолчанию 
        /// </summary>
        public Animal()
        {
            Name = null;
            HealPoint = -1;
            Age1 = -1;
        }
        /// <summary>
        /// Метод отнимания HP
        /// </summary>
        /// <param name="i">Кол-во "дамаги"</param>
        public void hpdown(int i)
        {
            HP -= i;
            if (HP <= 0)
            {
                Console.WriteLine("Him Die NOOOOOO! \n God pls NO!!!!");
            }
        }
        /// <summary>
        /// Конструктор животных
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="hP">Жизни</param>
        /// <param name="age">Возраст</param>
        public Animal(string name, int hP, int age)
        {
            HP = hP;
            Age = age;
            Name = name;
        }
        /// <summary>
        /// Вывод информации об обьекте
        /// </summary>
        /// <returns>Возвращает информацию об обьекте </returns>
        public virtual string info()
        {
            return $"\nHP:{HealPoint}\nAge:{Age1}";

        }

        public int HealPoint { get => HP; set => HP = value; }
        public int Age1 { get => Age; set => Age = value; }
        public string Name { get => name; set => name = value; }
    }
}
