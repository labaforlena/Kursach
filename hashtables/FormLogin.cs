using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        Dictionary<string, string> new_user = new Dictionary<string, string>();
         string login;
         string password;


        public static void addUser(ref Dictionary<string, string> new_user, string login, string password)
        {

            if (login == null)
            {
                Console.WriteLine("pls enter login");
            }
            else if (login != null)
            {
                if (password == null)
                {
                    Console.WriteLine("pls enter paswrd");
                }

            }
            else if (login != null)
            {
                if (password != null)
                {
                    new_user.Add(login, password);
                    Console.WriteLine("login:" + login + "  " + "password:" + password);
                }
            }
                


           
 

                
            
        }


       
        FormStart formEnter = new FormStart();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Hide();
            
            FormStart formEnter = new FormStart();
            formEnter.Show();
            addUser(ref new_user, login, password);
        }

        

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            login = textBoxLogin.Text;

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            password = textBoxPassword.Text;
        }


    }

    


}
