// Kelas: SI-25-04
// Kelompok: 01
// Anggota kelompok:
// 1. Ahmad Rizkirich Putra Arif (102042500076)
// 2. Bagas Riyadi (102042500156)
// 3. Rizkia Putri Handayani Rabika (102042500118)
// 4. Atta Rahman Raihannan (102042530017)
// 5. Cindy Jovanna Silitonga (102042500072)

public class Filtering
{
    public static void FilterData(Data data)
    {
        while (true)
        {
            Console.WriteLine("\n=== Filtering Barang ===");
            Console.WriteLine("1. Edible");
            Console.WriteLine("2. Non-Edible");
            Console.WriteLine("3. Kembali ke menu utama");
            Console.Write("Pilih metode pencarian (1/2/3): ");
            int pilihan_0401 = int.Parse(Console.ReadLine());
            switch (pilihan_0401)
            {
                case 1:
                    Filter.ProsesFilterEdible(data);
                    break;
                break;
                case 2:
                    Filter.ProsesFilterNonEdible(data);
                    break;
                break;
                case 3:
                    Console.WriteLine("Kembali ke menu utama.");
                    return;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                break;
            }
        }
    }
}