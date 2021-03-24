using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class KitapEmanetEL
    {
        int Id;

        int Kitap_Id;

        string VerilmeZamani;

        string TcNo;

        int IslemYapanKulaniciId;

        string TeslimZamani;

        bool TeslimEdilmeDurumu;

        public int id { get => Id; set => Id = value; }
        public int kitap_Id { get => Kitap_Id; set => Kitap_Id = value; }
        public string verilmeZamani { get => VerilmeZamani; set => VerilmeZamani = value; }
        public string tcNo { get => TcNo; set => TcNo = value; }
        public int islemYapanKulaniciId { get => IslemYapanKulaniciId; set => IslemYapanKulaniciId = value; }
        public string teslimZamani { get => TeslimZamani; set => TeslimZamani = value; }
        public bool teslimedilmedurumu { get => TeslimEdilmeDurumu; set => TeslimEdilmeDurumu = value; }
    }
}
