namespace SIPEKA.model
{
    partial class ObatFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObatFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kodeobat = new System.Windows.Forms.TextBox();
            this.txt_namaobat = new System.Windows.Forms.TextBox();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.cmb_jnsobat = new System.Windows.Forms.ComboBox();
            this.date_expired = new System.Windows.Forms.DateTimePicker();
            this.dgv_obat = new System.Windows.Forms.DataGridView();
            this.kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JenisObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaObat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.ubah_btn = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.batal_btn = new System.Windows.Forms.Button();
            this.btn_cetak = new System.Windows.Forms.Button();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_obat)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(275, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pengelolaan Data Obat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(7, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Obat";
            // 
            // txt_kodeobat
            // 
            this.txt_kodeobat.Enabled = false;
            this.txt_kodeobat.Location = new System.Drawing.Point(12, 204);
            this.txt_kodeobat.Multiline = true;
            this.txt_kodeobat.Name = "txt_kodeobat";
            this.txt_kodeobat.ReadOnly = true;
            this.txt_kodeobat.Size = new System.Drawing.Size(164, 30);
            this.txt_kodeobat.TabIndex = 20;
            // 
            // txt_namaobat
            // 
            this.txt_namaobat.Location = new System.Drawing.Point(12, 356);
            this.txt_namaobat.Multiline = true;
            this.txt_namaobat.Name = "txt_namaobat";
            this.txt_namaobat.Size = new System.Drawing.Size(164, 30);
            this.txt_namaobat.TabIndex = 22;
            // 
            // txt_stok
            // 
            this.txt_stok.Location = new System.Drawing.Point(12, 528);
            this.txt_stok.Multiline = true;
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(164, 30);
            this.txt_stok.TabIndex = 24;
            // 
            // cmb_jnsobat
            // 
            this.cmb_jnsobat.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmb_jnsobat.FormattingEnabled = true;
            this.cmb_jnsobat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_jnsobat.ItemHeight = 16;
            this.cmb_jnsobat.Location = new System.Drawing.Point(12, 280);
            this.cmb_jnsobat.Name = "cmb_jnsobat";
            this.cmb_jnsobat.Size = new System.Drawing.Size(164, 24);
            this.cmb_jnsobat.TabIndex = 25;
            // 
            // date_expired
            // 
            this.date_expired.CustomFormat = "dd MMM yyyy";
            this.date_expired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_expired.Location = new System.Drawing.Point(12, 444);
            this.date_expired.Name = "date_expired";
            this.date_expired.Size = new System.Drawing.Size(164, 22);
            this.date_expired.TabIndex = 26;
            // 
            // dgv_obat
            // 
            this.dgv_obat.AllowUserToAddRows = false;
            this.dgv_obat.AllowUserToDeleteRows = false;
            this.dgv_obat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_obat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode,
            this.JenisObat,
            this.NamaObat,
            this.ExpiredDate,
            this.Stok});
            this.dgv_obat.Location = new System.Drawing.Point(223, 222);
            this.dgv_obat.Name = "dgv_obat";
            this.dgv_obat.ReadOnly = true;
            this.dgv_obat.RowHeadersWidth = 51;
            this.dgv_obat.RowTemplate.Height = 24;
            this.dgv_obat.Size = new System.Drawing.Size(802, 417);
            this.dgv_obat.TabIndex = 27;
            this.dgv_obat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_obat_CellClick);
            // 
            // kode
            // 
            this.kode.DataPropertyName = "kode_obat";
            this.kode.HeaderText = "Kode Obat";
            this.kode.MinimumWidth = 6;
            this.kode.Name = "kode";
            this.kode.Width = 125;
            // 
            // JenisObat
            // 
            this.JenisObat.DataPropertyName = "jenis_obat";
            this.JenisObat.HeaderText = "Jenis Obat";
            this.JenisObat.MinimumWidth = 6;
            this.JenisObat.Name = "JenisObat";
            this.JenisObat.Width = 120;
            // 
            // NamaObat
            // 
            this.NamaObat.DataPropertyName = "nama_obat";
            this.NamaObat.HeaderText = "Nama Obat";
            this.NamaObat.MinimumWidth = 6;
            this.NamaObat.Name = "NamaObat";
            this.NamaObat.Width = 150;
            // 
            // ExpiredDate
            // 
            this.ExpiredDate.DataPropertyName = "ex_date";
            this.ExpiredDate.HeaderText = "Expired Date";
            this.ExpiredDate.MinimumWidth = 6;
            this.ExpiredDate.Name = "ExpiredDate";
            this.ExpiredDate.Width = 120;
            // 
            // Stok
            // 
            this.Stok.DataPropertyName = "stok";
            this.Stok.HeaderText = "Stok";
            this.Stok.MinimumWidth = 6;
            this.Stok.Name = "Stok";
            this.Stok.Width = 125;
            // 
            // simpan_btn
            // 
            this.simpan_btn.Location = new System.Drawing.Point(223, 129);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(88, 32);
            this.simpan_btn.TabIndex = 29;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = true;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // ubah_btn
            // 
            this.ubah_btn.Location = new System.Drawing.Point(341, 129);
            this.ubah_btn.Name = "ubah_btn";
            this.ubah_btn.Size = new System.Drawing.Size(88, 32);
            this.ubah_btn.TabIndex = 30;
            this.ubah_btn.Text = "Ubah";
            this.ubah_btn.UseVisualStyleBackColor = true;
            this.ubah_btn.Click += new System.EventHandler(this.ubah_btn_Click);
            // 
            // hapus_btn
            // 
            this.hapus_btn.Location = new System.Drawing.Point(462, 129);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(88, 32);
            this.hapus_btn.TabIndex = 31;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = true;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // batal_btn
            // 
            this.batal_btn.Location = new System.Drawing.Point(589, 129);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(88, 32);
            this.batal_btn.TabIndex = 32;
            this.batal_btn.Text = "Batal";
            this.batal_btn.UseVisualStyleBackColor = true;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
            // 
            // btn_cetak
            // 
            this.btn_cetak.Location = new System.Drawing.Point(720, 129);
            this.btn_cetak.Name = "btn_cetak";
            this.btn_cetak.Size = new System.Drawing.Size(88, 32);
            this.btn_cetak.TabIndex = 33;
            this.btn_cetak.Text = "Cetak";
            this.btn_cetak.UseVisualStyleBackColor = true;
            // 
            // btn_keluar
            // 
            this.btn_keluar.Location = new System.Drawing.Point(860, 129);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(88, 32);
            this.btn_keluar.TabIndex = 34;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_kodeobat);
            this.panel2.Controls.Add(this.cmb_jnsobat);
            this.panel2.Controls.Add(this.txt_namaobat);
            this.panel2.Controls.Add(this.date_expired);
            this.panel2.Controls.Add(this.txt_stok);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 651);
            this.panel2.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(7, 500);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Stok";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(7, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Date Expired";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(7, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nama Obat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(7, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Jenis Obat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 72);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 100);
            this.panel1.TabIndex = 38;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(229, 188);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(315, 22);
            this.txt_search.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(223, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 49);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari";
            // 
            // ObatFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 651);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_keluar);
            this.Controls.Add(this.btn_cetak);
            this.Controls.Add(this.batal_btn);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.ubah_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.dgv_obat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ObatFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obat";
            this.Load += new System.EventHandler(this.Obat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_obat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kodeobat;
        private System.Windows.Forms.TextBox txt_namaobat;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.ComboBox cmb_jnsobat;
        private System.Windows.Forms.DateTimePicker date_expired;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Button ubah_btn;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.Button btn_cetak;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn JenisObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaObat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok;
        private System.Windows.Forms.DataGridView dgv_obat;
    }
}