using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ElectricityConsumption
{
    class Program
    {
        public static List<Peralatan> listPeralatan = new List<Peralatan>();

        static void Main(string[] args)
        {
            listPeralatan.Add(new Peralatan() { NamaPeralatan = "AC", JmlPeralatan = 3, DayaListrik = 300, Pemakaian = 6 });

            int exit = 0;
            try
            {
                do
                {
                    Console.Clear();
                    MenuUtama(listPeralatan);
                    int pilih;
                    pilih = int.Parse(Console.ReadLine());
                    switch (pilih)
                    {
                        case 1:
                            Peralatan.DaftarPeralatan(listPeralatan);
                            break;
                        case 2:
                            Peralatan.AddPeralatan(listPeralatan);
                            break;
                        case 3:
                            Peralatan.UpdatePeralatan(listPeralatan);
                            break;
                        case 4:
                            Peralatan.RemovePeralatan(listPeralatan);
                            break;
                        case 5:
                            Hitung.KonsumsiListrik(listPeralatan);
                            break;
                        case 6:
                            exit = 1;
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Aksi yang anda input salah, silakan masukkan angka 1-6. Tekan enter untuk melanjutkan. ");
                            Console.ReadKey();
                            break;
                    }
                }
                while (exit == 0);
            }
            catch (FormatException)
            {
                Console.WriteLine("Masukan Input Not Valid");
                Console.ReadKey();
                MenuUtama(listPeralatan);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Write("Mohon Masukan Data dengan Benar");
                Console.ReadKey();
                MenuUtama(listPeralatan);
            }
        }

        static void MenuUtama(List<Peralatan> listPeralatan)
        {
            Console.Clear();
            Console.WriteLine("Sistem Perhitungan Pemakaian Listrik");
            Console.WriteLine("====================================");
            string[] menuList = { "1. List Peralatan", "2. Tambah Peralatan", "3. Update Peralatan", "4. Hapus Peralatan", "5. Hitung Konsumsi Listrik", "6. Keluar" };
            foreach (string menu in menuList)
            {
                Console.WriteLine(menu);
            }
            Console.Write("Masukan Aksi Pilihan Anda (hanya berupa angka): ");
        }
    }
}