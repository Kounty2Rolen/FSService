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
        public List<string> GetValue(List<Animal> animal) {
            SqlCommand sqlc = new SqlCommand(@"SELECT ID,Name,HP,age,squad FROM [Table]", sql);
            List<string> vs = new List<string>();
            using (var reader = sqlc.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader.HasRows)
                        //vs.Add(reader.GetValue(1) + ";" + reader.GetValue(2) + ";" + reader.GetValue(3) + ";" + reader.GetValue(4) + ";");
                        switch (reader.GetValue(4))
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
            }

            sqlc.Dispose();
                return vs;
        } 
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
                        var id = reader.GetValue(0);
                        var Name = reader.GetValue(1);
                        var HP = reader.GetValue(2);
                        var Age = reader.GetValue(3);
                        var squad = reader.GetValue(4);
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", id, Name, HP, Age);
                    }
                }
            }

            sqlc.Dispose();
        }
    }
}
