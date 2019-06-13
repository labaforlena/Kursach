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
    public partial class FormStartQuest : Form
    {
        public FormStartQuest()
        {
            InitializeComponent();
        }
        //btnLeave
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            FormStart formStart = new FormStart();
            formStart.Show();
        }

        private void btnToDungeon_Click(object sender, EventArgs e)
        {
            Close();
            FormComplexity formComplexity = new FormComplexity();
            formComplexity.Show();
        }

        private void btnAtackFort_Click(object sender, EventArgs e)
        {

            Close();
            FormAtackFort formAtackFort = new FormAtackFort();
            formAtackFort.Show();
        }

        
        private void btnAtackKorovan_Click(object sender, EventArgs e)
        {
            if (FormLogin.currentUser.stamina > 0)
            {
                korovanAtack();
                FormLogin.currentUser.stamina--;
            }

            else
            {
                DialogResult result = MessageBox.Show(
                  "You are tired. Pls sleep, for God's sake",
                  " ",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning,
                  MessageBoxDefaultButton.Button1,
                  MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        public void korovanAtack()
        {
            Random rand = new Random();
            int a = rand.Next(1, 4);
            Random randAtack = new Random();

            int atc = FormLogin.currentUser.countAttack();
            int df = FormLogin.currentUser.countDef();

            int b = randAtack.Next(atc - a , atc + a);

            Random randDef = new Random();
            int c = randDef.Next(df - a, df + a);

            int charReward = (b+c);
            if (b < FormLogin.currentUser.atack && c < FormLogin.currentUser.def)
            {
                //win
                int rewardMoney = Convert.ToInt32(((charReward * 2) + 1) * 4);
                FormLogin.currentUser.money += rewardMoney;

                int rewardExp = Convert.ToInt32(((charReward * 2) + 1) * 3);
                FormLogin.currentUser.exp += rewardExp;

                DialogResult result = MessageBox.Show(
                  "You saved the karavan! Get your prize: " + "\n" + "Money: " + rewardMoney + "\n" + "Exp:  " + rewardExp,
                  "Win!",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Exclamation,
                  MessageBoxDefaultButton.Button1,
                  MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.OK)
                {
                    
                    Connection.updDB();

                }

            } else
            {
                int fine = Convert.ToInt32(((charReward * 2) + 1) * 4);
                FormLogin.currentUser.money -= fine;

                DialogResult result = MessageBox.Show(
                 "You were too weak to save the karavan! You were robbed: " + "\n" + "Money: " + fine ,
                 "Lost!",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error,
                 MessageBoxDefaultButton.Button1,
                 MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.OK)
                {
                    Connection.updDB();

                }

            }
        }

    }
}
