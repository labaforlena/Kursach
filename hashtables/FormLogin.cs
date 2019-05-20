using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hashtables
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

    }

    public static string dbUsersPath = "C:\\Users\\Helena\\Documents\\GitHub\\Kursach\\hashtables\\userInfo.mdf";
        public static string dbUsersConnectionString = "Data Source = " + dbUsersPath;




        //static void TryCreateTable()
        //{
        //    using (SqlConnection con = new SqlConnection(hashtables.Properties.Settings.Default.userInfoConnectionString))
        //    {
        //        con.Open();
        //        try
        //        {
        //            using (SqlCommand command = new SqlCommand(
        //                "CREATE TABLE Users (login TEXT, password VARCHAR, HP INT)", con))
        //            {
        //                command.ExecuteNonQuery();
        //            }
        //        }
        //        catch
        //        {
        //            Console.WriteLine("Table not created.");
        //        }
        //    }
        //}

        static internal User currentUser = new User();
        string login;
        string password;
        Dictionary<string, string> new_user = new Dictionary<string, string>();
        

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (login == null)
            {
                Console.WriteLine("pls enter login");
            }
            else if (login != null && password == null)
            {
                Console.WriteLine("pls enter paswrd");

            }
            else if (login != null && password != null)
            {
                currentUser.login = login;
                Console.WriteLine("login:" + login + "  " + "password:" + password);

                FormLogin formLogin = new FormLogin();
                formLogin.Hide();

                FormStart formStart = new FormStart();
                formStart.Show();
            }


            /*
            addUser(ref new_user, login, password);
            FormUser formUser = new FormUser();
            formUser.labelLoginCount.Text = login;



               // Tr  yCreateTable();

            
               // Console.WriteLine("table exists");
          using (SqlConnection con = new SqlConnection(hashtables.Properties.Settings.Default.userInfoConnectionString))
                {
                    con.Open();
                    try
                    {
                    using (SqlCommand command = new SqlCommand(
                    "INSERT INTO Users (@login, @password) VALUES", con))
                    {
                        command.Parameters.Add(new SqlParameter("login", login));
                        command.Parameters.Add(new SqlParameter("password", password));
                        command.ExecuteNonQuery();
                    }
                     }
                    catch
                    {
                        Console.WriteLine("Count not insert.");
                    }
                }
            
            */

        }
             

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            login = textBoxLogin.Text;

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            password = textBoxPassword.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
    
}
