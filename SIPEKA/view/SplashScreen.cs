﻿using SIPEKA.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIPEKA
{
    public partial class SplashScreen : Form
    {
        int waktu = 0;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (waktu == 5)
            {
                Login_frm login = new Login_frm();
                login.Show();
                this.Hide();
                timer1.Enabled = false;
            }
            waktu++;
        }
    }
}