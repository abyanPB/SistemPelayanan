    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MySql.Data.MySqlClient;
    using System.Data.OleDb;

    namespace SIPEKA.model
    {
        using config;
        using System.Data;

        class Login
        {
            ServiceDb dbServer;
            DataTable dtTable;
            String Query = "";

            private string username;
            private string password;

            public Login()
            {
                username = "";
                password = "";

                dtTable = new DataTable();
                dbServer = new ServiceDb();
                Query = ""; 
            }

            public string Username
            {
                set { username = value; }
            }

            public string Password
            {
                set { password = value; }
            }

            public bool cekUserPassword(string user, string pass)
            {
                bool cek = false;
                Query = "select * from user where username='" + user + "' and password='"+ pass +"'";
                dtTable = dbServer.eksekusiQuery(Query);

                if (dtTable.Rows.Count > 0)
                {
                    cek = true;
                }
                return cek;
            }
        public string tampilNamaByKode(string user, string pass)
        {
            string nama = "";

            Query = "select nama_user from user where username='" + user + "' and password='" + pass + "'";

            dtTable = dbServer.eksekusiQuery(Query);
            if (dtTable.Rows.Count > 0)
            {
                foreach (DataRow data in dtTable.Rows)
                {
                    nama = data[0].ToString();
                }
            }
            return nama;
        }


    }
    }
