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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void btnStartQuest_Click(object sender, EventArgs e)
        {
            FormStartQuest formStartQuest = new FormStartQuest();
            formStartQuest.Show();
            Close();
        }

        private void btnSeeUser_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser();
            formUser.Show();
            Close();
           // formUser.labelLoginCount.Text 
        }
        //btnClose
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}
