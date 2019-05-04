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

        public static void updDB()
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();

            //Update changed staff
            conn.Close();
        }

        public static void getDB()
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();

<<<<<<< HEAD
            //Get Info
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
=======
            //Update changed staff
            conn.Close();
>>>>>>> c940ef62717d7f59265dfa76037f5f5fc2934c55
        }
    }
}
