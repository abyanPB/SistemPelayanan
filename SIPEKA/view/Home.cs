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
        public Home()
        {
            InitializeComponent();
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

        
    }
}
