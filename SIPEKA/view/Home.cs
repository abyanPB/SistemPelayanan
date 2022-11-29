using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIPEKA.view
{
    public partial class Home : Form
    {
        model.Login home = new model.Login();
        public Home(string user, string pass)
        {
            InitializeComponent();
            nama_lbl.Text = home.tampilNamaByKode(user, pass);
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dOKTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dokter_frm dokter = new Dokter_frm();
            dokter.ShowDialog();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal ;
        }

        private void dokter_btn_Click(object sender, EventArgs e)
        {
            Dokter_frm dokter = new Dokter_frm();
            dokter.ShowDialog();
        }
    }
}
