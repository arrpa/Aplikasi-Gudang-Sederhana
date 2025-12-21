// Kelas: SI-25-04
// Kelompok: 01
// Anggota kelompok:
// 1. Ahmad Rizkirich Putra Arif (102042500076)
// 2. Bagas Riyadi (102042500156)
// 3. Rizkia Putri Handayani Rabika (102042500118)
// 4. Atta Rahman Raihannan (102042530017)
// 5. Cindy Jovanna Silitonga (102042500072)

public class Searching
{
    public static void ProsesSearchById(Data data)
    {
        Console.Write("Masukkan ID Barang: ");
        int id_0401 = int.Parse(Console.ReadLine());

        int index_0401 = data.CariIndexById(id_0401);
        if (index_0401 != -1)
        {
            Console.WriteLine($"\nBarang ditemukan!");
            Console.WriteLine($"ID: {data.IdBarang_0401[index_0401]}");
            Console.WriteLine($"Nama: {data.NamaBarang_0401[index_0401]}");
            Console.WriteLine($"Harga: {data.HargaBarang_0401[index_0401]}");
            Console.WriteLine($"Stok: {data.StokBarang_0401[index_0401]}");
            Console.WriteLine($"Jenis Barang: {data.Kategori_0401[index_0401]}");
            return;
        }
        else
        {
            Console.WriteLine("Barang dengan ID tersebut tidak ditemukan.");
            return;
        }
    }

    public static void ProsesSearchByNama(Data data)
    {
        Console.Write("Masukkan Nama Barang: ");
        string nama_0401 = Console.ReadLine().ToLower();

        bool ditemukan_0401 = false;
        for (int i = 0; i < data.GetLength(); i++)
        {
            if (data.NamaBarang_0401[i] != null && data.NamaBarang_0401[i].ToLower().Contains(nama_0401))
            {
                if (!ditemukan_0401)
                {
                    Console.WriteLine("Hasil pencarian:");
                    ditemukan_0401 = true;
                }
                Console.WriteLine($"\nBarang ditemukan!");
                Console.WriteLine($"ID: {data.IdBarang_0401[i]}");
                Console.WriteLine($"Nama: {data.NamaBarang_0401[i]}");
                Console.WriteLine($"Harga: {data.HargaBarang_0401[i]}");
                Console.WriteLine($"Stok: {data.StokBarang_0401[i]}");
                Console.WriteLine($"Jenis Barang: {data.Kategori_0401[i]}");
            }
        }

        if (!ditemukan_0401)
        {
            Console.WriteLine("Barang dengan nama tersebut tidak ditemukan.");
        }
    }
}