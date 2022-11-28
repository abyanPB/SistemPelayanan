namespace SIPEKA.view
{
    partial class Dokter_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.kode_dokter_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nama_dokter_txt = new System.Windows.Forms.TextBox();
            this.telepon_txt = new System.Windows.Forms.TextBox();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.hapus_txt = new System.Windows.Forms.Button();
            this.ubah_txt = new System.Windows.Forms.Button();
            this.cetak_txt = new System.Windows.Forms.Button();
            this.batal_txt = new System.Windows.Forms.Button();
            this.spesialis_cmb = new System.Windows.Forms.ComboBox();
            this.jadwal_cmb = new System.Windows.Forms.ComboBox();
            this.keluar_txt = new System.Windows.Forms.Button();
            this.dokter_dgv = new System.Windows.Forms.DataGridView();
            this.Kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spesialis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_telepon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jadwal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dokter_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Dokter";
            // 
            // kode_dokter_txt
            // 
            this.kode_dokter_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kode_dokter_txt.Location = new System.Drawing.Point(300, 97);
            this.kode_dokter_txt.Name = "kode_dokter_txt";
            this.kode_dokter_txt.Size = new System.Drawing.Size(342, 30);
            this.kode_dokter_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jadwal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Spesialis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nama Dokter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nomor Telepon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "DOKTER";
            // 
            // nama_dokter_txt
            // 
            this.nama_dokter_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_dokter_txt.Location = new System.Drawing.Point(300, 142);
            this.nama_dokter_txt.Name = "nama_dokter_txt";
            this.nama_dokter_txt.Size = new System.Drawing.Size(342, 30);
            this.nama_dokter_txt.TabIndex = 9;
            // 
            // telepon_txt
            // 
            this.telepon_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telepon_txt.Location = new System.Drawing.Point(300, 249);
            this.telepon_txt.Name = "telepon_txt";
            this.telepon_txt.Size = new System.Drawing.Size(342, 30);
            this.telepon_txt.TabIndex = 10;
            // 
            // simpan_btn
            // 
            this.simpan_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan_btn.Location = new System.Drawing.Point(300, 354);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(103, 37);
            this.simpan_btn.TabIndex = 12;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = true;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // hapus_txt
            // 
            this.hapus_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_txt.Location = new System.Drawing.Point(539, 354);
            this.hapus_txt.Name = "hapus_txt";
            this.hapus_txt.Size = new System.Drawing.Size(103, 37);
            this.hapus_txt.TabIndex = 13;
            this.hapus_txt.Text = "Hapus";
            this.hapus_txt.UseVisualStyleBackColor = true;
            // 
            // ubah_txt
            // 
            this.ubah_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubah_txt.Location = new System.Drawing.Point(419, 354);
            this.ubah_txt.Name = "ubah_txt";
            this.ubah_txt.Size = new System.Drawing.Size(103, 37);
            this.ubah_txt.TabIndex = 14;
            this.ubah_txt.Text = "Ubah";
            this.ubah_txt.UseVisualStyleBackColor = true;
            // 
            // cetak_txt
            // 
            this.cetak_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cetak_txt.Location = new System.Drawing.Point(300, 401);
            this.cetak_txt.Name = "cetak_txt";
            this.cetak_txt.Size = new System.Drawing.Size(103, 37);
            this.cetak_txt.TabIndex = 16;
            this.cetak_txt.Text = "Cetak";
            this.cetak_txt.UseVisualStyleBackColor = true;
            // 
            // batal_txt
            // 
            this.batal_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal_txt.Location = new System.Drawing.Point(419, 401);
            this.batal_txt.Name = "batal_txt";
            this.batal_txt.Size = new System.Drawing.Size(103, 37);
            this.batal_txt.TabIndex = 17;
            this.batal_txt.Text = "Batal";
            this.batal_txt.UseVisualStyleBackColor = true;
            // 
            // spesialis_cmb
            // 
            this.spesialis_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spesialis_cmb.FormattingEnabled = true;
            this.spesialis_cmb.Location = new System.Drawing.Point(300, 194);
            this.spesialis_cmb.Name = "spesialis_cmb";
            this.spesialis_cmb.Size = new System.Drawing.Size(342, 33);
            this.spesialis_cmb.TabIndex = 18;
            // 
            // jadwal_cmb
            // 
            this.jadwal_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jadwal_cmb.FormattingEnabled = true;
            this.jadwal_cmb.Location = new System.Drawing.Point(300, 298);
            this.jadwal_cmb.Name = "jadwal_cmb";
            this.jadwal_cmb.Size = new System.Drawing.Size(342, 33);
            this.jadwal_cmb.TabIndex = 19;
            // 
            // keluar_txt
            // 
            this.keluar_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluar_txt.Location = new System.Drawing.Point(539, 401);
            this.keluar_txt.Name = "keluar_txt";
            this.keluar_txt.Size = new System.Drawing.Size(103, 37);
            this.keluar_txt.TabIndex = 20;
            this.keluar_txt.Text = "Keluar";
            this.keluar_txt.UseVisualStyleBackColor = true;
            // 
            // dokter_dgv
            // 
            this.dokter_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dokter_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dokter_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kode,
            this.Nama,
            this.Spesialis,
            this.No_telepon,
            this.Jadwal});
            this.dokter_dgv.Location = new System.Drawing.Point(54, 475);
            this.dokter_dgv.Name = "dokter_dgv";
            this.dokter_dgv.RowHeadersWidth = 51;
            this.dokter_dgv.RowTemplate.Height = 24;
            this.dokter_dgv.Size = new System.Drawing.Size(677, 150);
            this.dokter_dgv.TabIndex = 21;
            // 
            // Kode
            // 
            this.Kode.DataPropertyName = "kode_dokter";
            this.Kode.HeaderText = "Kode Dokter";
            this.Kode.MinimumWidth = 6;
            this.Kode.Name = "Kode";
            this.Kode.Width = 125;
            // 
            // Nama
            // 
            this.Nama.DataPropertyName = "nama_dokter";
            this.Nama.HeaderText = "Nama Dokter";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.Width = 125;
            // 
            // Spesialis
            // 
            this.Spesialis.DataPropertyName = "spesialis";
            this.Spesialis.HeaderText = "Spesialis";
            this.Spesialis.MinimumWidth = 6;
            this.Spesialis.Name = "Spesialis";
            this.Spesialis.Width = 125;
            // 
            // No_telepon
            // 
            this.No_telepon.DataPropertyName = "no_telepon";
            this.No_telepon.HeaderText = "Nomor Telepon";
            this.No_telepon.MinimumWidth = 6;
            this.No_telepon.Name = "No_telepon";
            this.No_telepon.Width = 125;
            // 
            // Jadwal
            // 
            this.Jadwal.DataPropertyName = "jadwal";
            this.Jadwal.HeaderText = "Jadwal";
            this.Jadwal.MinimumWidth = 6;
            this.Jadwal.Name = "Jadwal";
            this.Jadwal.Width = 125;
            // 
            // Dokter_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 637);
            this.Controls.Add(this.dokter_dgv);
            this.Controls.Add(this.keluar_txt);
            this.Controls.Add(this.jadwal_cmb);
            this.Controls.Add(this.spesialis_cmb);
            this.Controls.Add(this.batal_txt);
            this.Controls.Add(this.cetak_txt);
            this.Controls.Add(this.ubah_txt);
            this.Controls.Add(this.hapus_txt);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.telepon_txt);
            this.Controls.Add(this.nama_dokter_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kode_dokter_txt);
            this.Controls.Add(this.label1);
            this.Name = "Dokter_frm";
            this.Text = "Dokter_frm";
            this.Load += new System.EventHandler(this.Dokter_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dokter_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kode_dokter_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nama_dokter_txt;
        private System.Windows.Forms.TextBox telepon_txt;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Button hapus_txt;
        private System.Windows.Forms.Button ubah_txt;
        private System.Windows.Forms.Button cetak_txt;
        private System.Windows.Forms.Button batal_txt;
        private System.Windows.Forms.ComboBox spesialis_cmb;
        private System.Windows.Forms.ComboBox jadwal_cmb;
        private System.Windows.Forms.Button keluar_txt;
        private System.Windows.Forms.DataGridView dokter_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spesialis;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_telepon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jadwal;
    }
}