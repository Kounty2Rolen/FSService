﻿using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using q2.Models;


namespace q2.DB_Work
{
    class DBinit
    {
        private SqlConnection sql;
        public DBinit()
        {
            if (sql == null || sql.State == System.Data.ConnectionState.Closed)
            {
                openconn();
            }
            else
            {
                Console.WriteLine("Подключение уже существует");

            }
        }
        public void openconn()
        {
            sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ALL\FSService\q2\q2\DB_Work\Database.mdf;Integrated Security=True");
            sql.Open();
        }
        public void closeconn()
        {
            sql.Close();
            sql.Dispose();
        }
        /// <summary>
        /// Метод для чтения данных из бд и создания обьектов по ключевому полю Squad
        /// </summary>
        /// <param name="animal">Список в который будут добавлятся обьекты</param>
        public List<Animal> GetValue()
        {
            List<Animal> animal = new List<Animal>();
            using (SqlCommand sqlc = new SqlCommand(@"SELECT Name,HP,AGE,squad,injail,egg,paws FROM [Table]", sql))
            {
                using (var reader = sqlc.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        switch (reader["squad"])
                        {
                            case "Bird":
                                {
                                    animal.Add(new Kesha(reader));
                                    break;
                                }
                            case "Cat":
                                {
                                    animal.Add(new mycat(reader));
                                    break;
                                }

                        }
                    }
                    //foreach (Animal a in animal)
                    //    a.Serialize(reader);
                }
            }

            return animal;

        }
        /// <summary>
        /// Метод вывода содержимого бд на экран
        /// </summary>
        
    }
}
