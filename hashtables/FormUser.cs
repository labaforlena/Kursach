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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
            labelLoginCount.Text = FormLogin.currentUser.login;
            labelHPCount.Text = Convert.ToString(FormLogin.currentUser.hp);
        }
       

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
            FormStart formStart = new FormStart();
            formStart.Show();
        }

        
    }
}
