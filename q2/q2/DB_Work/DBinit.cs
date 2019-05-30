using System;
using System.Data.SqlClient;


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
        #region Сериализация 
        public void openconn()
        {
            sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Root\Desktop\ALL\FSService\q2\q2\DB_Work\Database.mdf;Integrated Security=True");
            sql.Open();
        }
        public void closeconn()
        {
            sql.Close();
            sql.Dispose();
        }
        public void serialized(String name, int hp, int age, string Class)
        {
            var id = 0;
            SqlCommand sqlc = new SqlCommand("SELECT MAX(id) FROM [Table]", sql);
            using (var reader = sqlc.ExecuteReader())
            {

                if (reader.HasRows)
                {
                    if (reader.Read())
                        id = Convert.ToInt32(reader.GetValue(0));
                    reader.Close();
                    sqlc.CommandText = @"INSERT INTO [Table] (ID,NAME,HP,AGE,squad) values ('" + (id + 1) + "','" + name + "','" + Convert.ToString(hp) + "','" + Convert.ToString(age) + "','" + Class + "')";
                    sqlc.ExecuteNonQuery();

                }
                else
                {
                    reader.Close();
                    sqlc.CommandText = @"INSERT INTO [Table] (ID,NAME,HP,AGE,squad) values ('0','" + name + "','" + Convert.ToString(hp) + "','" + Convert.ToString(age) + "','" + Class + "')";
                    sqlc.ExecuteNonQuery();
                }

            }
        }
        #endregion
        public string[] deserialized(int id)
        {
            SqlCommand sqlc = new SqlCommand(@"SELECT ID,Name,HP,age,squad FROM [Table] WHERE ID="+id, sql);
            using (var reader = sqlc.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    string[] row = new string[5] {reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString()};
                    return row;
                }
                Console.ReadLine();
            }
            string[] zero = new string[0];
            return zero;
        }

        public void display()
        {
            openconn();

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
