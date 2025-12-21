// Kelas: SI-25-04
// Kelompok: 01
// Anggota kelompok:
// 1. Ahmad Rizkirich Putra Arif (102042500076)
// 2. Bagas Riyadi (102042500156)
// 3. Rizkia Putri Handayani Rabika (102042500118)
// 4. Atta Rahman Raihannan (102042530017)
// 5. Cindy Jovanna Silitonga (102042500072)

public class Filter
{
    public static void ProsesFilterEdible(Data data)
    {
        bool ditemukan_0401 = false;
        int count_0401 = 0;
        Data.JenisBarang_0401 jenis_0401 = Data.JenisBarang_0401.EDIBLE;

        for (int i = 0; i < data.GetLength(); i++)
        {
            Console.WriteLine("\n=== Barang-barang Edible ===");
            if (data.Kategori_0401[i] == jenis_0401)
            {
                Console.WriteLine($"\nID: {data.IdBarang_0401[i]}");
                Console.WriteLine($"Nama: {data.NamaBarang_0401[i]}");
                Console.WriteLine($"Harga: {data.HargaBarang_0401[i]}");
                Console.WriteLine($"Stok: {data.StokBarang_0401[i]}");
                ditemukan_0401 = true;
                count_0401++;
            }
        }
    }

    public static void ProsesFilterNonEdible(Data data)
    {
        bool ditemukan_0401 = false;
        int count_0401 = 0;
        Data.JenisBarang_0401 jenis_0401 = Data.JenisBarang_0401.NONEDIBLE;

        for (int i = 0; i < data.GetLength(); i++)
        {
            Console.WriteLine("\n=== Barang-barang nonedible ===");
            if (data.Kategori_0401[i] == jenis_0401)
            {
                Console.WriteLine($"\nID: {data.IdBarang_0401[i]}");
                Console.WriteLine($"Nama: {data.NamaBarang_0401[i]}");
                Console.WriteLine($"Harga: {data.HargaBarang_0401[i]}");
                Console.WriteLine($"Stok: {data.StokBarang_0401[i]}");
                ditemukan_0401 = true;
                count_0401++;
            }
        }
    }
}