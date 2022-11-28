using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPEKA.view
{
    using model;
    public partial class Login_frm : Form
    {
        model.Login log = new model.Login();
        public Login_frm()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();     
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (log.cekUserPassword(username_txt.Text, password_txt.Text))
            {
                Home utama = new Home();
                utama.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password Anda Salah");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
