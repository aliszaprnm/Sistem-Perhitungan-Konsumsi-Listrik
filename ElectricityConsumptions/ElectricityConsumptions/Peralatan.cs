using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElectricityConsumption
{
    class Peralatan
    {
        public string NamaPeralatan { get; set; }
        public int JmlPeralatan { get; set; }
        public int DayaListrik { get; set; }
        public int Pemakaian { get; set; }

        public Peralatan(string NamaPeralatan, int JmlPeralatan, int DayaListrik, int Pemakaian)
        {
            this.NamaPeralatan = NamaPeralatan;
            this.JmlPeralatan = JmlPeralatan;
            this.DayaListrik = DayaListrik;
            this.Pemakaian = Pemakaian;
        }

        public Peralatan()
        {
        }

        public static void AddPeralatan(List<Peralatan> listPeralatan)
        {
            Console.Clear();

            Peralatan peralatan = new Peralatan();

            Console.Write("Nama Peralatan\t\t: ");
            peralatan.NamaPeralatan = Console.ReadLine();

            Console.Write("Jumlah Peralatan\t: ");
            peralatan.JmlPeralatan = Convert.ToInt32(Console.ReadLine());

            Console.Write("Daya Listrik (Watt)\t: ");
            peralatan.DayaListrik = Convert.ToInt32(Console.ReadLine());

            Console.Write("Pemakaian (Jam/Hari)\t: ");
            peralatan.Pemakaian = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Total Daya\t\t: {peralatan.JmlPeralatan * peralatan.DayaListrik * peralatan.Pemakaian} Watt");

            listPeralatan.Add(peralatan);
            Console.ReadKey();
        }

        public static void UpdatePeralatan(List<Peralatan> listPeralatan)
        {
            Console.Clear();
            Console.WriteLine("Masukkan nama peralatan yang ingin diubah pemakaiannya.");
            string namaPeralatan = Console.ReadLine();
            Peralatan peralatan = listPeralatan.FirstOrDefault(x => x.NamaPeralatan.ToLower() == namaPeralatan.ToLower());
            if (peralatan == null)
            {
                Console.Write("Peralatan tersebut tidak ditemukan. Tekan enter untuk kembali ke menu utama");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Apakah Anda yakin ingin mengubah pemakaian pada peralatan ini? (Y/N)");
            TampilData(peralatan);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.Write("\nPemakaian Sekarang: ");
                var pemakaianNow = Convert.ToInt32(Console.ReadLine());
                peralatan.Pemakaian = pemakaianNow;
                Console.WriteLine("-----------------------------------------------");
                Console.Write("Pemakaian Berhasil Diganti\n");
                TampilData(peralatan);
                Console.ReadKey();
            }
        }

        public static void TampilData(Peralatan peralatan)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Nama Peralatan\t\t: {peralatan.NamaPeralatan}");
            Console.WriteLine($"Jumlah Peralatan\t: {peralatan.JmlPeralatan}");
            Console.WriteLine($"Daya Listrik\t\t: {peralatan.DayaListrik} Watt");
            Console.WriteLine($"Pemakaian per Hari\t: {peralatan.Pemakaian} Jam");
            Console.WriteLine($"Total Daya\t\t: {peralatan.JmlPeralatan * peralatan.DayaListrik * peralatan.Pemakaian} Watt");
            Console.WriteLine("-----------------------------------------------");
        }

        public static void DaftarPeralatan(List<Peralatan> listPeralatan)
        {
            Console.Clear();
            if (listPeralatan.Count == 0)
            {
                Console.WriteLine("Tidak ada peralatan di sini. Tekan enter untuk kembali ke menu utama.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Berikut daftar peralatan yang terdapat di sini:");
            foreach (var peralatan in listPeralatan)
            {
                TampilData(peralatan);
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu utama.");
            Console.ReadKey();
        }

        public static void RemovePeralatan(List<Peralatan> listPeralatan)
        {
            Console.Clear();
            Console.WriteLine("Masukkan nama peralatan yang ingin dihapus.");
            string namaPeralatan = Console.ReadLine();
            Peralatan peralatan = listPeralatan.FirstOrDefault(x => x.NamaPeralatan.ToLower() == namaPeralatan.ToLower());
            if (peralatan == null)
            {
                Console.Write("Peralatan tersebut tidak ditemukan. Tekan enter untuk kembali ke menu utama");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Apakah Anda yakin ingin menghapus peralatan ini? (Y/N)");
            TampilData(peralatan);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                listPeralatan.Remove(peralatan);
                Console.Write("\nPeralatan berhasil dihapus. Tekan enter untuk kembali ke menu utama.");
                Console.ReadKey();
            }
        }
    }
}
