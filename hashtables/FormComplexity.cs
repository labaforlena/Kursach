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
    public partial class FormComplexity : Form
    {
        public FormComplexity()
        {
            InitializeComponent();
        }

        public void generateDungeon(int complexity)
        {
            if (FormLogin.currentUser.stamina > 0)
            {
                Random rand = new Random();
                int id = rand.Next(1, 28);
                Dungeon current = Connection.GetDungeon(id);
                current.complexity = complexity;

                FormLogin.currentUser.stamina--;

                Close();
                FormQuest formQuest = new FormQuest(current);
                formQuest.Show();
            }
            else {
                DialogResult result = MessageBox.Show(
                  "You are tired. Pls sleep, for God's sake",
                  " ",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning,
                  MessageBoxDefaultButton.Button1,
                  MessageBoxOptions.DefaultDesktopOnly);
                              
            }
        }

       
        private void btnEasy_Click(object sender, EventArgs e)
        {
            generateDungeon(1);

        }
        //предметы и монстры
        private void btnHard_Click(object sender, EventArgs e)
        {
            generateDungeon(3);
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            generateDungeon(2);
        }
        private void btnLeave_Click(object sender, EventArgs e)
        {
            Close();
            FormStartQuest formStartQuest = new FormStartQuest();
            formStartQuest.Show();
        }


    }
}
