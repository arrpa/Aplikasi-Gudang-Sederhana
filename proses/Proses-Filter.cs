public class Filter
{
    public static void ProsesFilterEdible(Data data)
    {
        bool ditemukan = false;
        int count = 0;
        Data.JenisBarang jenis = Data.JenisBarang.edible;

        for (int i = 0; i < data.GetLength(); i++)
        {
            Console.WriteLine("=== Filtering Barang ===");
            if (data.Kategori[i] == jenis)
            {
                Console.WriteLine($"ID: {data.IdBarang[i]}");
                Console.WriteLine($"Nama: {data.NamaBarang[i]}");
                Console.WriteLine($"Harga: {data.HargaBarang[i]}");
                Console.WriteLine($"Stok: {data.StokBarang[i]}");
                ditemukan = true;
                count++;
            }
        }
    }

    public static void ProsesFilterNonEdible(Data data)
    {
        bool ditemukan = false;
        int count = 0;
        Data.JenisBarang jenis = Data.JenisBarang.nonedible;

        for (int i = 0; i < data.GetLength(); i++)
        {
            Console.WriteLine("=== Filtering Barang ===");
            if (data.Kategori[i] == jenis)
            {
                Console.WriteLine($"ID: {data.IdBarang[i]}");
                Console.WriteLine($"Nama: {data.NamaBarang[i]}");
                Console.WriteLine($"Harga: {data.HargaBarang[i]}");
                Console.WriteLine($"Stok: {data.StokBarang[i]}");
                ditemukan = true;
                count++;
                return;
            }
        }
    }
}