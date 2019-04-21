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
    }
}
