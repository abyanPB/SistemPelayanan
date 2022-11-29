using SIPEKA.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SIPEKA.view
{
    public partial class Dokter_frm : Form
    {
        model.Dokter dokter = new model.Dokter();
        public Dokter_frm()
        {
            InitializeComponent();
        }

        void tampilGrid()
        {
            dokter_dgv.DataSource = dokter.tampilkanSemua();
            belangBelang(dokter_dgv);
        }

        void isiAgama()
        {
            spesialis_cmb.Items.Clear();
            spesialis_cmb.Items.Add("Dokter Bedah");
            spesialis_cmb.Items.Add("Dokter Anak");
            spesialis_cmb.Items.Add("Dokter Penyakit Dalam");
            spesialis_cmb.Items.Add("Dokter Umum");
        }

        void isiJadwal()
        {
            jadwal_cmb.Items.Clear();
            jadwal_cmb.Items.Add("Senin");
            jadwal_cmb.Items.Add("Selasa");
            jadwal_cmb.Items.Add("Rabu");
            jadwal_cmb.Items.Add("Kamis");
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            if (!dokter.cekKode(kode_dokter_txt.Text))
            {
                dokter.Kode_Dokter = kode_dokter_txt.Text;
                dokter.Nama_Dokter = nama_dokter_txt.Text;
                dokter.Spesialis = spesialis_cmb.Text;
                dokter.No_Telepon = telepon_txt.Text;
                dokter.Jadwal = jadwal_cmb.Text;
                dokter.simpanData();
                MessageBox.Show("Data Berhasil Disimpan.");
            }
            tampilGrid();
            kode_dokter_txt.Text = dokter.buatKode();
            kode_dokter_txt.Focus();
        }

        private void Dokter_frm_Load(object sender, EventArgs e)
        {
            tampilGrid();
            isiAgama();
            isiJadwal();
            bersihkan();
        }

        void bersihkan()
        {
            kode_dokter_txt.Clear();
            nama_dokter_txt.Clear();
            spesialis_cmb.Text = "";
            telepon_txt.Clear();
            jadwal_cmb.Text = "";
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

        private void ubah_txt_Click(object sender, EventArgs e)
        {
            if (dokter.cekKode(kode_dokter_txt.Text))
            {
                if (MessageBox.Show("Yakin akan diubah ?", "Ubah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dokter.Kode_Dokter = kode_dokter_txt.Text;
                    dokter.Nama_Dokter = nama_dokter_txt.Text;
                    dokter.Spesialis = spesialis_cmb.Text;
                    dokter.No_Telepon = telepon_txt.Text;
                    dokter.Jadwal = jadwal_cmb.Text;

                    dokter.ubahData(kode_dokter_txt.Text);


                    MessageBox.Show("Ubah Data Berhasil.", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    tampilGrid();
                    kode_dokter_txt.Focus();
                }
            }
        }

        private void hapus_txt_Click(object sender, EventArgs e)
        {
            if (dokter.cekKode(kode_dokter_txt.Text))
            {
                if (MessageBox.Show("Yakin akan dihapus ?", "Ubah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dokter.hapusData(kode_dokter_txt.Text);

                    MessageBox.Show("Hapus Data Berhasil.", "Hapus Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    tampilGrid();
                    kode_dokter_txt.Focus();
                }
            }
        }

        private void keluar_txt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void batal_txt_Click(object sender, EventArgs e)
        {
            bersihkan();
            kode_dokter_txt.Focus();
        }
    }
}
