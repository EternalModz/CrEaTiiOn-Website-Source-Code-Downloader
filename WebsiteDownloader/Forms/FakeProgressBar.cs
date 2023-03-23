﻿using System;
using System.Windows.Forms;

namespace WebSrcDL_CBH.Forms
{
    public partial class FakeProgressBar : Form
    {
        public FakeProgressBar()
        {
            InitializeComponent();
        }

        private void FakeProgressBar_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 68)
            {
                int random_number = new Random().Next(1, 10);
                progressBar1.Value += random_number;
            }
        }
    }
}
