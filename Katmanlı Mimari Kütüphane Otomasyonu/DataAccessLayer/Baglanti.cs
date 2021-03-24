using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static OleDbConnection baglantı = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Kütüphanedatabase1sdx.mdb");
    }
}
