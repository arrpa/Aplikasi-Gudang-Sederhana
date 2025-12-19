public class Filter
{
    public static void ProsesFilterEdible(Data data)
    {
        bool ditemukan_0401 = false;
        int count_0401 = 0;
        Data.JenisBarang_0401 jenis_0401 = Data.JenisBarang_0401.edible;

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
        Data.JenisBarang_0401 jenis_0401 = Data.JenisBarang_0401.nonedible;

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