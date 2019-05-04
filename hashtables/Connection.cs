using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace hashtables
{
    class Connection
    {
        public static MySqlConnection GetDBConnection()
        {
            string datasource = "104.248.19.220";

            string database = "test";
            string username = "Test";
            string password = "1234";


            string connString = "server=" + datasource + ";Port=3306;Database=" + database + ";Uid=" + username + ";Pwd=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }


        //Возможно сделать перегрузку для каждой колонки
        public static void updDB()
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();

            //Update changed staff
            conn.Close();
        }


        //Выгружает всю инфу про перса из БД, вызывать при входе
        public static void getFullDB(string login)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();

            string sql = "SELECT * FROM test WHERE login ='" + login + "';"; //проверить названия колонок в таблице
            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                //По очереди присваивать строкам из внутренней бд значения reader[i]
            }
            conn.Close();
        }

        //Такая же но  по ID
        public static void getFullDB(int ID)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();

            string sql = "SELECT * FROM test WHERE ID ='" + ID + "';"; //проверить названия колонок в таблице
            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                //По очереди присваивать строкам из внутренней бд значения reader[i]
            }
            conn.Close();
        }


        //Возвращает бул тру если логин и парль правильные
        public static bool login(string login, string pass)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();

            string sql = "SELECT password FROM test WHERE login ='" + login + "';"; //проверить названия колонок в таблице
            MySqlCommand command = new MySqlCommand(sql, conn);

            

            if (pass == command.ExecuteScalar().ToString())
            {
                return true;
            }

            conn.Close();
            return false;
        }


    }
}
