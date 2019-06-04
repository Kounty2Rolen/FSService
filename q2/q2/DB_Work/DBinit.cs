using System;
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
        public void GetValue(List<Animal> animal)
        {
            SqlCommand sqlc = new SqlCommand(@"SELECT Name,HP,AGE,squad,injail FROM [Table]", sql);
            using (var reader = sqlc.ExecuteReader())
            {
                while (reader.Read())
                {
                    switch (reader["squad"])
                    {
                        case "Bird":
                            {
                                animal.Add(new Kesha());
                                animal[animal.Count-1].Serialize(reader); 
                                break;
                            }
                        case "Cat":
                            {
                                animal.Add(new mycat());
                                animal[animal.Count-1].Serialize(reader);
                                break;
                            }

                    }
                }
            }

            //Высвобождение всех ресурсов занятых Sqlc
            sqlc.Dispose();
        }
        /// <summary>
        /// Метод вывода содержимого бд на экран
        /// </summary>
        public void display()
        {
            SqlCommand sqlc = new SqlCommand(@"SELECT ID,Name,HP,age,squad FROM [Table]", sql);
            using (var reader = sqlc.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\n\n", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3), reader.GetName(4)); ;
                    while (reader.Read())
                    {
                        var id = reader["ID"];
                        var Name = reader["name"];
                        var HP = reader["HP"];
                        var Age = reader["age"];
                        var squad = reader["squad"];
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", id, Name, HP, Age);
                    }
                }
            }

            sqlc.Dispose();
        }
    }
}
