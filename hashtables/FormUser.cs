using System;
using System.Collections;
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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
            labelLoginCount.Text = FormLogin.currentUser.login;
            labelStaminaCount.Text = Convert.ToString(FormLogin.currentUser.stamina);
            labelAtackCount.Text = Convert.ToString(FormLogin.currentUser.atack);
            labelDefCount.Text = FormLogin.currentUser.def.ToString();
            labelBankCount.Text = FormLogin.currentUser.money.ToString();
            labelLevelCount.Text = FormLogin.currentUser.level.ToString();
            labelExpCount.Text = FormLogin.currentUser.exp.ToString();

            
            for (int i = 0; i < FormLogin.currentUser.itemsInBag.Count; i++)
            {
                listBoxItemsInBag.Items.Add((i + 1) + ". " + FormLogin.currentUser.itemsInBag[i].name);
            }

            for (int i = 0; i < FormLogin.currentUser.itemsInHand.Count; i++)
            {
                listBoxItemsInHand.Items.Add((i + 1) + ". " + FormLogin.currentUser.itemsInHand[i].name);
            }

            if (levelUp())
            {
                levelUpBox.Visible = true;
            }
            else
            {
                levelUpBox.Visible = false;
            }
        }

        public class avatar
        {
            internal string itemInList { get; set; }
            internal string ImagePath { get; set; }

            public override string ToString()
            {
                return itemInList;
            }
        }

        private void btnAva_Click(object sender, EventArgs e)
        {
            pictureBoxAva.ImageLocation = "C:/Users/Helena/Documents/GitHub/Kursach/hashtables/Resources/" + comboBox1.Text + ".png";
            pictureBoxAva.BackgroundImageLayout = ImageLayout.Zoom;
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
        

        Bitmap[] image = new Bitmap[5];
        image[0] = new Bitmap(@"C:/Users/Helena/Documents/GitHub/Kursach/hashtables/Resources/ "+ comboBox1.Text +".png");
            image[1] = new Bitmap(@"C:/Users/Helena/Documents/GitHub/Kursach/hashtables/Resources/ " + comboBox1.Text + ".png");
            image[2] = new Bitmap(@"C:/Users/Helena/Documents/GitHub/Kursach/hashtables/Resources/ " + comboBox1.Text + ".png");
            image[3] = new Bitmap(@"C:/Users/Helena/Documents/GitHub/Kursach/hashtables/Resources/ " + comboBox1.Text + ".png");
            image[4] = new Bitmap(@"C:/Users/Helena/Documents/GitHub/Kursach/hashtables/Resources/ " + comboBox1.Text + ".png");

        }
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bitmap[] image = new Bitmap[5];
            switch (comboBox1.SelectedIndex)
            {
                case 0: pictureBoxAva.Image = image[0]; break;
                case 1: pictureBoxAva.Image = image[1]; break;
                case 2: pictureBoxAva.Image = image[2]; break;
                case 3: pictureBoxAva.Image = image[3]; break;
                case 4: pictureBoxAva.Image = image[4]; break;

            }

        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            Connection.updDB();
            Close();
            FormStart formStart = new FormStart();
            formStart.Show();
        }

        private bool levelUp()
        {
            int exp = FormLogin.currentUser.exp;
            int level = FormLogin.currentUser.level;
            if (Math.Exp((++level)) <= exp)
            {
                return true;
                Connection.updDB();

            }
            else
            {
                return false;
                Connection.updDB();

            }
        }

        private void btnAddAttack_Click(object sender, EventArgs e)
        {
            FormLogin.currentUser.level++;
            FormLogin.currentUser.atack++;
            if (!levelUp()) { levelUpBox.Visible = false; }
            labelAtackCount.Text = Convert.ToString(FormLogin.currentUser.atack);
            labelLevelCount.Text = Convert.ToString(FormLogin.currentUser.level);
            Connection.updDB();

        }

        private void btnAddDef_Click(object sender, EventArgs e)
        {
            FormLogin.currentUser.level++;
            FormLogin.currentUser.def++;
            if (!levelUp()) { levelUpBox.Visible = false; }
            labelDefCount.Text = Convert.ToString(FormLogin.currentUser.def);
            labelLevelCount.Text = Convert.ToString(FormLogin.currentUser.level);
            Connection.updDB();

        }

        private void listBoxItemsInHand_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxItemsInHand.SelectedIndex >= 0)
            {
                Console.WriteLine(listBoxItemsInHand.SelectedIndex);
                FormLogin.currentUser.itemsInBag.Add(FormLogin.currentUser.itemsInHand[listBoxItemsInHand.SelectedIndex]);
                FormLogin.currentUser.itemsInHand.RemoveAt(listBoxItemsInHand.SelectedIndex);

                listBoxItemsInHand.Items.Clear();
                for (int i = 0; i < FormLogin.currentUser.itemsInHand.Count; i++)
                {
                    listBoxItemsInHand.Items.Add((i + 1) + ". " + FormLogin.currentUser.itemsInHand[i].name);
                    Connection.updDB();

                }

                listBoxItemsInBag.Items.Clear();
                for (int i = 0; i < FormLogin.currentUser.itemsInBag.Count; i++)
                {
                    listBoxItemsInBag.Items.Add((i + 1) + ". " + FormLogin.currentUser.itemsInBag[i].name);
                    Connection.updDB();

                }
            }
            Connection.updDB();
        }

        private void listBoxItemsInBag_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxItemsInBag.SelectedIndex >= 0)
            {
                Console.WriteLine(listBoxItemsInBag.SelectedIndex);
                FormLogin.currentUser.itemsInHand.Add(FormLogin.currentUser.itemsInBag[listBoxItemsInBag.SelectedIndex]);
                FormLogin.currentUser.itemsInBag.RemoveAt(listBoxItemsInBag.SelectedIndex);

                listBoxItemsInBag.Items.Clear();
                for (int i = 0; i < FormLogin.currentUser.itemsInBag.Count; i++)
                {
                    listBoxItemsInBag.Items.Add((i + 1) + ". " + FormLogin.currentUser.itemsInBag[i].name);
                    FormLogin.currentUser.atack -= FormLogin.currentItem.attack;
                    FormLogin.currentUser.def += FormLogin.currentItem.def;


                    Connection.updDB();

                }

                listBoxItemsInHand.Items.Clear();
                for (int i = 0; i < FormLogin.currentUser.itemsInHand.Count; i++)
                {
                    listBoxItemsInHand.Items.Add((i + 1) + ". " + FormLogin.currentUser.itemsInHand[i].name);
                    FormLogin.currentUser.atack += FormLogin.currentItem.attack;
                    FormLogin.currentUser.def += FormLogin.currentItem.def;

                    Connection.updDB();

                }
            }
            Connection.updDB();
        }
    }
}
