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

        }

        public static void getDB()
        {

        }
    }
}
