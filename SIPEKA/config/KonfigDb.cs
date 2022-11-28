using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SIPEKA.config
{
    abstract class KonfigDb
    {
        //Untuk menangani instruksi INSERT, UPDATE, DELETE
        public abstract int eksekusiNonQuery(string query);

        //untuk menangan instruksi Select
        public abstract DataTable eksekusiQuery(string query);
    }
}
