﻿using System;
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
        //тут только предметы в подземелье
        private void btnEasy_Click(object sender, EventArgs e)
        {

        }
        //предметы и монстры
        private void btnHard_Click(object sender, EventArgs e)
        {

        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            Close();
            FormStartQuest formStartQuest = new FormStartQuest();
            formStartQuest.Show();
        }
    }
}
