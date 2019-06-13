using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace hashtables
{
    public partial class FormAtackFort : Form
    {
        public FormAtackFort()
        {
            InitializeComponent();
            if(FormLogin.currentUser.attackFort == true)
            {
                btnAttack.Text = "x not attack";

            }
            else btnAttack.Text = ">atacc";
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            Connection.updDB();
            Close();
            FormStartQuest formStartQuest = new FormStartQuest();
            formStartQuest.Show();
        }


        private void btnAttack_Click(object sender, EventArgs e)
        {
            SetTimer();
            FormLogin.currentUser.attackFort = !FormLogin.currentUser.attackFort;
            if (FormLogin.currentUser.attackFort == true)
            {

                btnAttack.Text = "x not attack";

            }
            else btnAttack.Text = ">atacc";
            Connection.updDB();
        }
        private static void SetTimer()
        {
            System.Timers.Timer aTimer = new System.Timers.Timer(60000);//3/5 min in milisec
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Button btnAttack = new Button();
            btnAttack.Text = ">atacc";

            MessageBox.Show("Fort was attacked");

            Console.WriteLine("Fort was attacked",
                              e.SignalTime);
        }

    }
}
