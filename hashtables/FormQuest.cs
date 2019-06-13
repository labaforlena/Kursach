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
    public partial class FormQuest : Form
    {

        public Dungeon dungeon;

        public FormQuest(Dungeon dungeon)
        {
            InitializeComponent();

            questText.Text = dungeon.mainText.Replace(@".", "\n");

            btnAns1.Text = dungeon.answ1;
            btnAns2.Text = dungeon.answ2;
            btnAns3.Text = dungeon.answ3;

            if (dungeon.type == 1)
            {
                btnAns1.Visible = false;
                btnAns2.Visible = false;
                btnAns3.Text = "ОТВЕТ";
            }
            if (dungeon.type == 2)
            {
                textBoxAnswer.Visible = false;
                btnAns3.Text = "[sarcasm]";
            }
            if (dungeon.type == 3)
            {
                textBoxAnswer.Visible = false;
                btnAns1.Visible = false;
                btnAns2.Visible = false;
                btnAns3.Text = "ну ок :с";
            }
            this.dungeon = dungeon;
        }

        
           
    

        private void btnAns1_Click(object sender, EventArgs e)
        {
            //money only
            int reward = Convert.ToInt32(((dungeon.complexity * 2) % FormLogin.currentUser.level+1) * 1.2);
            FormLogin.currentUser.money += reward;
            DialogResult result = MessageBox.Show(
                   dungeon.reaction1 + "\n" + "You got: " + "\n " +"Money: " + reward,
                   " ",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.OK)
            {
                Close();
                Connection.updDB();
            }

        }

        private void btnAns3_Click(object sender, EventArgs e)
        {
            if (dungeon.type == 2)
            {
                btn3type2Clicked();
            }
            else if(dungeon.type == 1)
            {
                btn3type1Clicked();
            }
            else if (dungeon.type == 3)
            {
                btn3type3Clicked();
            }
        }

        private void btn3type3Clicked()
        {

            DialogResult result = MessageBox.Show(
                      dungeon.reaction3,
                      " ",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning,
                      MessageBoxDefaultButton.Button1,
                      MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.OK)
            {
                Close();
                Connection.updDB();

            }
        }

        private void btn3type1Clicked()
        {
            if (textBoxAnswer.Text == dungeon.answ1 || textBoxAnswer.Text == dungeon.answ2 || textBoxAnswer.Text == dungeon.answ3)
            {
                Random rand = new Random();
                if (rand.Next(1, 5) == 1)
                {
                    Item item = new Item();
                    item.id = rand.Next(0, 100);
                    item = Connection.getItem(item.id);
                    if (item.name != null)
                    {
                        FormLogin.currentUser.itemsInBag.Add(item);
                    }
                }
                DialogResult result = MessageBox.Show(
                       dungeon.reaction1 + "\n" + "You got: " + FormLogin.currentUser.itemsInBag.Last<Item>().name,
                       " ",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.OK)
                {
                    Close();
                    Connection.updDB();

                }
            }
            else
            {
                DialogResult result = MessageBox.Show(
                      dungeon.reaction2,
                      " ",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning,
                      MessageBoxDefaultButton.Button1,
                      MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.OK)
                {
                    Close();
                    Connection.updDB();

                }
            }
        }

        private void btn3type2Clicked()
        {
            //lil money+lil exp
            int reward = Convert.ToInt32(((dungeon.complexity * 2) % FormLogin.currentUser.level + 1) * 1.2);
            FormLogin.currentUser.money += reward;

            int rewardExp = Convert.ToInt32(((dungeon.complexity * 2) % FormLogin.currentUser.level + 1) * 1.2);
            FormLogin.currentUser.exp += rewardExp;

            DialogResult result = MessageBox.Show(
                   dungeon.reaction3 + "\n" + "You got: " + "\n" + "Money: "+ reward + " Exp:  " + rewardExp,
                   " ",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.OK)
            {
                Close();
                Connection.updDB();

            }
        }

        private void btnAns2_Click(object sender, EventArgs e)
        {
            //exp only
            int rewardExp = Convert.ToInt32(((dungeon.complexity * 2) % FormLogin.currentUser.level+1) * 1.2);
            FormLogin.currentUser.exp += rewardExp;

            DialogResult result = MessageBox.Show(
                   dungeon.reaction2 + "\n" + "You got" + " " + rewardExp,
                   " ",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.OK)
            {
                Close();
                Connection.updDB();

            }
        }
    }
}
