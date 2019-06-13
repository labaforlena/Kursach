using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace hashtables
{
    class Connection
    {
        static internal User currentUser = new User();

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

        internal static Dungeon GetDungeon(int id)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();

            string sql = "SELECT type FROM Quest WHERE id ='" + id + "';"; //проверить названия колонок в таблице
            MySqlCommand command = new MySqlCommand(sql, conn);

            int type = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            Dungeon dungeon = new Type3();

            switch (type)
                {
                case 1:
                    dungeon = new Type1();
                    break;
                case 2:
                    dungeon = new Type2();
                    break;
                case 3:
                    dungeon = new Type3();
                    break;
                default:
                    Console.WriteLine("Ooopss...");
                    break; 
            }

            //присваеваем всем полям данжна значения бд
            conn.Open();

            sql = "SELECT * FROM Quest WHERE id ='" + id + "';"; //проверить названия колонок в таблице
            command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dungeon.id = id;
                dungeon.mainText = Convert.ToString(reader[2]);
                dungeon.type = Convert.ToInt32(reader[1]);
                dungeon.answ1 = Convert.ToString(reader[3]);
                dungeon.answ2 = Convert.ToString(reader[4]);
                dungeon.answ3 = Convert.ToString(reader[5]);
                dungeon.reaction1 = Convert.ToString(reader[6]);
                dungeon.reaction2 = Convert.ToString(reader[7]);
                dungeon.reaction3 = Convert.ToString(reader[8]);
                
            }
            conn.Close();
            return dungeon;
        }


        //Возможно сделать перегрузку для каждой колонки
        public static void updDB()
        {

            MySqlConnection conn = GetDBConnection();
            conn.Open();
            int attackFort;
            if (FormLogin.currentUser.attackFort)
            {
                attackFort = 1;
            }
            else
            {
                attackFort = 0;
            }

                string sql = "UPDATE User SET level=" + FormLogin.currentUser.level + "," +
                                            "money=" + FormLogin.currentUser.money + "," +
                                            "attack=" + FormLogin.currentUser.atack + "," +
                                            "defence=" + FormLogin.currentUser.def + "," +
                                            "itemsHeldId=" + "\"" + createJSON(FormLogin.currentUser.itemsInHand)+ "\"," +
                                            "itemsInBag=" + "\"" + createJSON(FormLogin.currentUser.itemsInBag) + "\"," +
                                            "attackFort=" + attackFort + "," +
                                            "stamina=" + FormLogin.currentUser.stamina + "," +
                                            "exp=" + FormLogin.currentUser.exp +
                                            " WHERE login = " + FormLogin.currentUser.login + ";";

            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();

            conn.Close();
        }

        private static string createJSON(List<Item> items)
        {
            //if (items.Last().id != null)
            
                string Ids = "{Ids: [";
                for (int i = 0; i < items.Count - 1; i++)
                {
                    Ids += items[i].id + ", ";
                }

            try
            {
                return (Ids += items.Last().id + "]}");
            }
            catch
            {
                return (Ids += "]}");
            }
        }
                     
        //Выгружает всю инфу про перса из БД, вызывать при входе
        public static User getFullDB(string login)
        {            
                User current = new User();
                MySqlConnection conn = GetDBConnection();
                conn.Open();

                string sql = "SELECT * FROM User WHERE login ='" + login + "';"; //проверить названия колонок в таблице
                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();
            List<int> itemsIdInBag = new List<int>();
            List<int> itemsIdInHand = new List<int>();
                
                while (reader.Read())
                {
                    current.login = reader[1].ToString();
                    current.level = Convert.ToInt32(reader[3]);
                    current.money = Convert.ToInt32(reader[4]);
                    current.atack = Convert.ToInt32(reader[5]);
                    current.def = Convert.ToInt32(reader[6]);
                    itemsIdInHand = JSONParser.jsonToIntArr(reader[7]).ToList<int>();
                    itemsIdInBag = JSONParser.jsonToIntArr(reader[8]).ToList<int>();
                    current.attackFort = Convert.ToBoolean(reader[9]);
                current.stamina = Convert.ToInt32(reader[10]);
                current.exp = Convert.ToInt32(reader[11]);
                }
                conn.Close();
            current.itemsInBag = getItemsHeld(itemsIdInBag);
            current.itemsInHand = getItemsHeld(itemsIdInHand);


            return current;
        }

        
        public static List<Item> getItemsHeld(List<int> itemsId)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();

            List<Item> items = new List<Item>();


            for (int i = 0; i < itemsId.Count; i++)
            {
                string sql = "SELECT attack FROM Items WHERE id ='" + itemsId[i] + "';"; //проверить названия колонок в таблице
                MySqlCommand command = new MySqlCommand(sql, conn);

                Item temp = new Item();
                temp.id = itemsId[i]; 
                temp.attack = Convert.ToInt32(command.ExecuteScalar());//В теории это будет JSON объект
                items.Add(temp);

            }

            for (int i = 0; i < itemsId.Count; i++)
            {
                string sql = "SELECT defence FROM Items WHERE id ='" + itemsId[i] + "';"; //проверить названия колонок в таблице
                MySqlCommand command = new MySqlCommand(sql, conn);

                items[i].def = Convert.ToInt32(command.ExecuteScalar());//В теории это будет JSON объект
            }

            for (int i = 0; i < itemsId.Count; i++)
            {
                string sql = "SELECT name FROM Items WHERE id ='" + itemsId[i] + "';"; //проверить названия колонок в таблице
                MySqlCommand command = new MySqlCommand(sql, conn);

                items[i].name = Convert.ToString(command.ExecuteScalar());//В теории это будет JSON объект
            }

            for (int i = 0; i < itemsId.Count; i++)
            {
                string sql = "SELECT value FROM Items WHERE id ='" + itemsId[i] + "';"; //проверить названия колонок в таблице
                MySqlCommand command = new MySqlCommand(sql, conn);

                items[i].value = Convert.ToInt32(command.ExecuteScalar());//В теории это будет JSON объект
            }
            conn.Close();

            //Console.WriteLine(items[0].name);
            return items;
        }

        public static Item getItem(int id)
        {
            Item item = new Item();
            MySqlConnection conn = GetDBConnection();
            conn.Open();

            string sql = "SELECT * FROM Items WHERE id ='" + id + "';"; //проверить названия колонок в таблице
            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                item.id = Convert.ToInt32(reader[0]);
                item.attack = Convert.ToInt32(reader[1]);
                item.def = Convert.ToInt32(reader[2]);
                item.name = Convert.ToString(reader[3]);
                item.value = Convert.ToInt32(reader[4]);
                                           }
            conn.Close();
            return item;
        }


        //Возвращает бул тру если логин и парль правильные
        public static bool login(string login, string pass)
        {
            try
            {
                MySqlConnection conn = GetDBConnection();
                conn.Open();

                string sql = "SELECT password FROM User WHERE login ='" + login + "';"; //проверить названия колонок в таблице
                MySqlCommand command = new MySqlCommand(sql, conn);

                if (pass == command.ExecuteScalar().ToString())
                {
                    return true;
                }
                conn.Close();


            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show(Convert.ToString(e));
            }
            return false;
        }

       internal static void insertUser(ref string login, ref string password)
        {            
            
                MySqlConnection conn = GetDBConnection();
                conn.Open();

                string sql = "INSERT INTO `User` (`id`, `login`, `password`, `level`, `money`, `attack`, `defence`, `itemsHeldId`, `itemsInBag`, `attackFort`, `stamina`, `exp`, `maxStamina`, `fort`) VALUES (null, '" + login +
                "', '" + password + 
                "', '1', '10', '1', '1', NULL, NULL, '0', '7', '0', '10000', '0');";
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = sql;

                MySqlParameter loginParam = new MySqlParameter("@login", MySqlDbType.String);
                loginParam.Value = login;
                command.Parameters.Add(loginParam);

                MySqlParameter passwordParam = new MySqlParameter("@password", MySqlDbType.String);
                passwordParam.Value = password;
                command.Parameters.Add(passwordParam);

            if (command.ExecuteNonQuery() == 1)
            {
                DialogResult result = MessageBox.Show(
                                "New user successfull added!" + "\n" + "Wanna join the dark side??",
                                "",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    sql = "UPDATE `User` SET `fort`= '0' WHERE `login` = " + login + ";";
                    command = new MySqlCommand(sql, conn);
                    command.ExecuteNonQuery();


                }
                
            }
            else if(command.ExecuteNonQuery() != 1)
            {

                DialogResult result = MessageBox.Show(
                 "Please enter login",
                 "Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button1,
                 MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.OK)
                {
                    TextBox textBoxLogin = new TextBox();
                    textBoxLogin.BackColor = Color.Red;
                }
            }
            conn.Close();
                conn.Dispose();
                conn = null;
            
               
            
       }

        //public bool UserExists()
        //SELECT EXISTS(SELECT id FROM table WHERE id = 1)

    }
}
