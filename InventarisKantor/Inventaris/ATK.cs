using System;

namespace InventarisKantor.Inventaris
{
    public class ATK : JenisInventaris
    {

        public ATK(int Kode, string Name, string Jenis, int Jumlah) : base(Kode, Name, Jenis, Jumlah)
        {
        }

        public override void Pengkodean(int Kode)
        {
            base.Pengkodean(Kode);
            Console.WriteLine("Kode : " + Kode);
        }
        public override void Golongan(string jenis)
        {
            Console.WriteLine("Jenis " + jenis);
        }
        public override void Hitung(int Jumlah)
        {
            base.Hitung(Jumlah);
            Console.WriteLine("Jumlah : " + Jumlah);
        }
    }
}
