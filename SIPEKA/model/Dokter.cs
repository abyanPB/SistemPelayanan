using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPEKA.model
{
    using config;
    using System.Data;
    internal class Dokter
    {
        ServiceDb dbServer;
        DataTable temp;
        string Query = "";

        private string kode_dokter;
        private string nama_dokter;
        private string spesialis;
        private string no_telepon;
        private string jadwal;

        public Dokter()
        {
            dbServer = new ServiceDb();
            temp = new DataTable();

            kode_dokter = "";
            nama_dokter = "";
            spesialis = "";
            no_telepon = "";
            jadwal = "";
        }

        public string Kode_Dokter
        {
            set { kode_dokter = value; }
        }

        public string Nama_Dokter
        {
            set { nama_dokter = value; }
        }
        
        public string Spesialis
        {
            set { spesialis = value; }
        }
        
        public string No_Telepon
        {
            set { no_telepon = value; }
        }

        public string Jadwal
        {
            set { jadwal = value; }
        }

        public bool cekKode(string kode)
        {
            bool cek = false;
            Query = "select * from dokter where kode_dokter='" + kode + "'";

            temp = dbServer.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public void simpanData()
        {
            Query = "insert into dokter values ('" + kode_dokter + "','" + nama_dokter + "', '" + spesialis + "', '" + no_telepon + "', '" + jadwal + "')";

            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal Disimpan.");    
            }
        }

        public void ubahData(string kode)
        {
            Query = "update dokter set nama_dokter='" + nama_dokter + "' spesialis='" + spesialis + "' no_telepon='" + no_telepon + "' jadwal='" + jadwal + "'" + "where kode_jurusan='" + kode + "'";

            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal Diubah.");
            }
        }

        public void hapusData(string kode)
        {
            Query = "delete from dokter where kode_jurusan='" + kode + "'";

            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal Dihapus.");
            }
        }

        public DataTable tampilkanSemua()
        {
            Query = "select * from dokter";

            return dbServer.eksekusiQuery(Query);
        }

        public string tampilNamaByKode(string kode)
        {
            string nama = "";

            Query = "select nama_jurusan from jurusan where kode_jurusan='" + kode + "'";

            temp = dbServer.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    nama = data[0].ToString();
                }
            }
            return nama;
        }

        public string buatKode()
        {
            string kode = "";
            int indek = 0;

            Query = "select IFNULL (MAX(kode_jurusan),0) + 1 AS kode FROM jurusan";

            temp = dbServer.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {   
                    indek = Convert.ToInt32(data[0]);
                }
                if (indek > 0 && indek < 10)
                {
                    kode = "0" + indek.ToString();
                }
                else if (indek >= 10 && indek < 100)
                {
                    kode = indek.ToString();
                }
            }

            return kode;
        }

        public string ambilKodeJurusanbyNama(string nama)
        {
            string kd = "";

            Query = "select kode_jurusan from jurusan where nama_jurusan='" + nama + "'";
            temp = dbServer.eksekusiQuery(Query);

            if (temp.Rows.Count > 0)
            {
                foreach (DataRow dt in temp.Rows)
                {
                    kd = dt[0].ToString();
                }
            }
            return kd;
        }

    }
}
