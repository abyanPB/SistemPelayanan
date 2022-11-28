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
        }
    }
}
