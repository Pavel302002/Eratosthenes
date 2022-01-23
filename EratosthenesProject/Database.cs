using System.Data.SQLite;
using System.IO;
using System.Data;
using System.Data.Common;

namespace EratosthenesProject
{
    class Database
    {
        private string dbPath = @"users.db";//путь к БД

        //Проверка существования файла БД
        public Database()
        {
            if (!File.Exists(dbPath))
            {
                Initialize();
            }
        }
        //Если не существует - создаем
        private void Initialize()
        {
            File.Create(dbPath).Close();
            SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", dbPath));
            //Если находим таблицу, то удаляем ее, чтобы не было ошибок перезаписи
            SQLiteCommand command = new SQLiteCommand("DROP TABLE IF EXISTS users;"
                                                        + "CREATE TABLE usersInfo("
                                                        + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                                                        + "username TEXT, "
                                                        + "password TEXT); ", connection);
            connection.Open();
            command.ExecuteNonQuery(); //запись в БД
            connection.Close();
        }

        public bool Valid(string username, string password)
        {
            SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", dbPath));
            connection.Open();
            //проходим по всем значениям в БД
            SQLiteCommand command1 = new SQLiteCommand("SELECT * FROM 'usersInfo'; ", connection);
            SQLiteDataReader reader = command1.ExecuteReader(); //заносим в reader все значения 
            string tempUsername = "";
            string tempPassword = "";
            foreach (DbDataRecord record in reader) //перебор значений поочереди из reader
            {
                tempUsername = record["username"].ToString();
                tempPassword = record["password"].ToString();
                //проверка соответствия введенных данных с данными из БД
                if (username == tempUsername && password == tempPassword)
                {
                    connection.Close();
                    return true;
                }
            }
            connection.Close();
            return false;
        }

        //проверяем имя пользователя на уникальность
        public bool Exists(string username)
        {
            SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", dbPath));
            connection.Open();
            SQLiteCommand command1 = new SQLiteCommand("SELECT * FROM 'usersInfo'; ", connection);
            SQLiteDataReader reader = command1.ExecuteReader();
            string tempUsername;
            foreach (DbDataRecord record in reader)
            {
                tempUsername = record["username"].ToString();
                if (username == tempUsername)
                {
                    connection.Close();
                    return true;
                }
            }
            connection.Close();
            return false;
        }

        public void Create(string username, string password)
        {
            SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", dbPath));
            connection.Open();
            //добавляем в таблицу значения ..., которые равны ...
            SQLiteCommand command = new SQLiteCommand("INSERT INTO 'usersInfo' ('username', 'password') VALUES (@username, @password); ", connection);
            command.Parameters.Add("@username", DbType.String).Value = username;
            command.Parameters.Add("@password", DbType.String).Value = password;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
