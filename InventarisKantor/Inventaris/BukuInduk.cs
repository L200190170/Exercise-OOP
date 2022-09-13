using System;
using System.Collections.Generic;
using System.Text;

namespace InventarisKantor.Inventaris
{
    public class BukuInduk
    {
        public virtual void Tanggal(string tanggal)
        {
            tanggal = DateTime.Now.ToString("dd/MMM/yyyy");
            Console.WriteLine(tanggal);
        }

        public virtual void Pengkodean(int Kode)
        {
        }

        //overloading
        public void NamaBarang(string Name)
        {
            Console.WriteLine("Berikut Nama Barangnya" + "\n" + Name);
        }

        public void NamaBarang(string Name2, string Name3, int Jumlah)
        {
            Console.WriteLine(Name2 + "\n" + "Jumlah : " + Jumlah + "\n" + Name3);
        }
        public virtual void Golongan(string Jenis)
        {
            Console.WriteLine(Jenis);
        }
        public virtual void Hitung(int Jumlah)
        {
        }
    }
}
