using System;
using System.Collections.Generic;
using System.Text;

namespace InventarisKantor.Inventaris
{
    public class JenisInventaris : BukuInduk
    {
        public JenisInventaris(int Kode, string Name, string Jenis, int Jumlah)
        {
            this.Kode = Kode;
            this.Name = Name;
            this.Jenis = Jenis;
            this.Jumlah = Jumlah;
        }
        //public JenisInventaris
        //{

        //}
        public int Kode { get; protected set; }
        public string Name { get; protected set; }
        public string Jenis { get; protected set; }
        public int Jumlah { get; protected set; }

    }
}
