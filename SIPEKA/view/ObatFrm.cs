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
            txt_kodeobat.Text = obat.buatKode();
            txt_kodeobat.Focus();
            tampilData();
            isiJenisObat();

        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            if (!obat.apakahAda(txt_kodeobat.Text))
            {
                obat.Kode_Obat = txt_kodeobat.Text;
                obat.Jns_Obat = cmb_jnsobat.Text;
                obat.Nama_Obat = txt_namaobat.Text;
                obat.Exp_Date = ambilTanggal(date_expired.Value);
                obat.Stok = txt_stok.Text;
                obat.simpan();

                MessageBox.Show("Tambah data berhasil.", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersihkan();
                tampilData();
                txt_kodeobat.Focus();
            }
        }
        private void ubah_btn_Click(object sender, EventArgs e)
        {
            if (obat.apakahAda(txt_kodeobat.Text))
            {
                if (MessageBox.Show("Yakin akan diubah ?", "Ubah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    obat.Kode_Obat = txt_kodeobat.Text;
                    obat.Nama_Obat = txt_namaobat.Text;
                    obat.Jns_Obat = cmb_jnsobat.Text;
                    obat.Exp_Date = ambilTanggal(date_expired.Value);
                    obat.Stok = txt_stok.Text;
                    obat.ubah(txt_kodeobat.Text);
                    MessageBox.Show("Ubah data berhasil.", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    tampilData();
                    txt_kodeobat.Focus();
                }
            }
        }
        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (obat.apakahAda(txt_kodeobat.Text))
            {
                if (MessageBox.Show("Yakin akan dihapus ?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    obat.hapus(txt_kodeobat.Text);
                    MessageBox.Show("Hapus data berhasil.", "Hapus Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    txt_kodeobat.Text = obat.buatKode();
                    tampilData();
                    txt_kodeobat.Focus();
                }
            }
        }


        private void dgv_obat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.dgv_obat.Rows[e.RowIndex];

            txt_kodeobat.Text = baris.Cells[0].Value.ToString();
            cmb_jnsobat.Text = baris.Cells[1].Value.ToString();
            txt_namaobat.Text = baris.Cells[2].Value.ToString();
            date_expired.Value=buatTanggal(baris.Cells[3].Value.ToString());
            txt_stok.Text = baris.Cells[4].Value.ToString();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
            txt_kodeobat.Focus();
        }
    }
}
