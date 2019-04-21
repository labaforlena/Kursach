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

       
        FormStart formEnter = new FormStart();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Hide();
            FormStart formEnter = new FormStart();
            formEnter.Show();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    


}
