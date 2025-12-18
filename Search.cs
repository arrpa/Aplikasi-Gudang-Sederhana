public class Search
{
    public static void CariBarang(Data data)
    {
        Console.WriteLine("=== Pencarian Barang ===");
        Console.WriteLine("1. Cari berdasarkan ID");
        Console.WriteLine("2. Cari berdasarkan Nama");
        Console.Write("Pilih metode pencarian (1/2): ");
        int pilihan = int.Parse(Console.ReadLine());

        if (pilihan == 1)
        {
            Console.Write("Masukkan ID Barang: ");
            int id = int.Parse(Console.ReadLine());

            int index = data.CariIndexById(id);
            if (index != -1)
            {
                Console.WriteLine($"Barang ditemukan!");
                Console.WriteLine($"ID: {data.IdBarang[index]}");
                Console.WriteLine($"Nama: {data.NamaBarang[index]}");
                Console.WriteLine($"Harga: {data.HargaBarang[index]}");
                Console.WriteLine($"Stok: {data.StokBarang[index]}");
            }
            else
            {
                Console.WriteLine("Barang dengan ID tersebut tidak ditemukan.");
            }
        }
        else if (pilihan == 2)
        {
            Console.Write("Masukkan Nama Barang: ");
            string nama = Console.ReadLine();

            bool ditemukan = false;
            for (int i = 0; i < data.GetLength(); i++)
            {
                if (data.NamaBarang[i] != null && data.NamaBarang[i].ToLower().Contains(nama.ToLower()))
                {
                    Console.WriteLine($"Barang ditemukan!");
                    Console.WriteLine($"ID: {data.IdBarang[i]}");
                    Console.WriteLine($"Nama: {data.NamaBarang[i]}");
                    Console.WriteLine($"Harga: {data.HargaBarang[i]}");
                    Console.WriteLine($"Stok: {data.StokBarang[i]}");
                    ditemukan = true;
                }
            }

            if (!ditemukan)
            {
                Console.WriteLine("Barang dengan nama tersebut tidak ditemukan.");
            }
        }
        else
        {
            Console.WriteLine("Pilihan tidak valid.");
        }

    }
}