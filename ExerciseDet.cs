﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flextrainer
{
    public partial class ExerciseDet : Form
    {
        public ExerciseDet()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkoutDays d = new WorkoutDays("");
            d.Show();
            this.Hide();
        }
    }
}
