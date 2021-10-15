using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricityConsumption
{
    class Barang : Peralatan
    {
        public static void KonsumsiListrik(List<Peralatan> listPeralatan)
        {
            Console.Clear();
            int totalDaya = 0;
            foreach (var peralatan in listPeralatan)
            {
                totalDaya = totalDaya + (peralatan.JmlPeralatan * peralatan.DayaListrik * peralatan.Pemakaian);
                TampilData(peralatan);
            }
            Console.WriteLine($"Total Konsumsi Listrik\t: {totalDaya} Watt");
            Console.ReadKey();
        }
    }
}
