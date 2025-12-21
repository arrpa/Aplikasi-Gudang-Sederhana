// Kelas: SI-25-04
// Kelompok: 01
// Anggota kelompok:
// 1. Ahmad Rizkirich Putra Arif (102042500076)
// 2. Bagas Riyadi (102042500156)
// 3. Rizkia Putri Handayani Rabika (102042500118)
// 4. Atta Rahman Raihannan (102042530017)
// 5. Cindy Jovanna Silitonga (102042500072)

public class Search
{
    public static void CariBarang(Data data)
    {
        while (true)
        {
            Console.WriteLine("\n=== Pencarian Barang ===");
            Console.WriteLine("1. Cari berdasarkan ID");
            Console.WriteLine("2. Cari berdasarkan Nama");
            Console.WriteLine("3. Kembali ke menu utama");
            Console.Write("Pilih metode pencarian (1/2/3): ");
            int pilihan_0401 = int.Parse(Console.ReadLine());

            try
            {
                switch (pilihan_0401)
                {
                    case 1:
                        Searching.ProsesSearchById(data);
                        break;
                    case 2:
                        Searching.ProsesSearchByNama(data);
                        break;
                    case 3:
                        Console.WriteLine("Kembali ke menu utama.");
                        return;
                    default:
                        Console.WriteLine("Pilihan tidak valid.");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Input tidak valid. Silakan masukkan bilangan bulat 1 atau 2.");
                continue;
            }
        }
    }
}