using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIPEKA.model
{
    using model;
    public partial class ObatFrm : Form
    {
        Obat obat = new Obat();
        
        public ObatFrm()
        {
            InitializeComponent();
        }
        void bersihkan()
        {
            txt_kodeobat.Clear();
            cmb_jnsobat.Text="";
            txt_namaobat.Clear();
            date_expired.Value=DateTime.Now;
            txt_stok.Clear();
        }
        void isiJenisObat()
        {
            cmb_jnsobat.Items.Add("Obat Cair");
            cmb_jnsobat.Items.Add("Kapsul");
            cmb_jnsobat.Items.Add("Tablet");
            cmb_jnsobat.Items.Add("Obat Tetes");
            cmb_jnsobat.Items.Add("Obat Suntik");
        }
        void tampilData()
        {
            if (txt_search.Text.Trim()=="")
            {
                dgv_obat.DataSource = obat.tampilSemuaGrid();
            }
            else
            {
                dgv_obat.DataSource = obat.tampilSemuaGrid(txt_search.Text);
            }
            belangBelang(dgv_obat);
        }
        void belangBelang(DataGridView dgv)
        {
            foreach (DataGridViewRow baris in dgv.Rows)
            {
                foreach (DataGridViewCell kolom in baris.Cells)
                {
                    if (baris.Index % 2 == 0)
                    {
                        kolom.Style.BackColor = Color.LightGray;
                    }
                    else
                    {
                        kolom.Style.BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }
        string ambilTanggal(DateTime tgl)
        {
            string stgl = "";
            stgl=tgl.Year.ToString()+"/"+tgl.Month.ToString()+"/"+tgl.Day.ToString();


            return stgl;
        }
        DateTime buatTanggal(string tgl)
        {
            DateTime dtgl = new DateTime(Convert.ToInt32(tgl.Substring(6, 4)), Convert.ToInt32(tgl.Substring(3, 2)), Convert.ToInt32(tgl.Substring(0, 2)));
            return dtgl;

        }

        private void Obat_Load(object sender, EventArgs e)
        {
            txt_kodeobat.Focus();
            tampilData();
            isiJenisObat();

        }


    }
}
