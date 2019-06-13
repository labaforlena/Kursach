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
using System.Timers;


namespace hashtables
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.ActiveControl = textBoxLogin;
        }

        //public static string dbUsersPath = "C:\\Users\\Helena\\Documents\\GitHub\\Kursach\\hashtables\\userInfo.mdf";
        //public static string dbUsersConnectionString = "Data Source = " + dbUsersPath;

        static internal User currentUser = new User();
        string login;
        string password;

        static internal Item currentItem = new Item();


        Dictionary<string, string> new_user = new Dictionary<string, string>();

        
        private void btnEnter_Click(object sender, EventArgs e)
        {
            

            if (login == null)
            {
                DialogResult result = MessageBox.Show(
                   "pls enter login",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.OK)
                {
                    textBoxLogin.BackColor = Color.Red;
                }

                Console.WriteLine("pls enter login");
            }
            else if (login != null && password == null)
            {
                MessageBox.Show("Please enter password");
                Console.WriteLine("pls enter paswrd");

            }
            else if (login != null && password != null)
            {
                if (Connection.login(login, password))
                {
                    currentUser = Connection.getFullDB(login);

                    Console.WriteLine("login:" + login + "  " + "password:" + password);
                    SetTimer();
                    Hide();

                    FormStart formStart = new FormStart();
                    formStart.Show();

                    FormUser formUser = new FormUser();
                    formUser.labelAtackCount.Text = Convert.ToString(currentUser.atack);
                    formUser.labelDefCount.Text = Convert.ToString(currentUser.def);


                }
                else
                {
                    MessageBox.Show("Upps...");

                    Console.WriteLine("Upps...");
                }
            }

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
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (login != null && password != null)
            {
                Connection.insertUser(ref login, ref password);
            }
           
        }

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            System.Timers.Timer aTimer = new System.Timers.Timer(9000);//3/5 min in milisec
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if(FormLogin.currentUser.stamina < FormLogin.currentUser.maxStamina)
            {
                FormLogin.currentUser.stamina++;
                Connection.updDB();
                MessageBox.Show("Stamina refreshed. Go and fight!");       
                Console.WriteLine("stamina refreshed",
                                  e.SignalTime);
            }
            
        }
    }
    
}
