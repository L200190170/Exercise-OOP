using InventarisKantor.Inventaris;
using System;

namespace InventarisKantor
{
    class Program
    {
        static void Main(string[] args)
        {

            ATK atk = new ATK(110,"Spidol", "Barang Habis Pakai", 10);
            atk.Tanggal("13 / 09 / 2022");
            atk.Pengkodean(111);
            atk.NamaBarang("Buku");
            atk.Hitung(10);
            atk.NamaBarang("Spidol", "Bolpoin", 20);
            atk.Hitung(10);
            atk.Golongan("Barang Habis Pakai");
        }
    }
}
