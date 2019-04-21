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
    public partial class FormAtackFort : Form
    {
        public FormAtackFort()
        {
            InitializeComponent();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            Close();
            FormStartQuest formStartQuest = new FormStartQuest();
            formStartQuest.Show();
        }
    }
}
