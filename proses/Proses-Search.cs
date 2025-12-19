public class Searching
{
    public static void ProsesSearchById(Data data)
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
            return;
        }
        else
        {
            Console.WriteLine("Barang dengan ID tersebut tidak ditemukan.");
            return;
        }
    }

    public static void ProsesSearchByNam(Data data)
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
                Console.Write("Kembali? (y/n): ");
                string jawab = Console.ReadLine().ToLower();
                if (jawab == "yes" || jawab == "y")
                {
                    Console.WriteLine("Pencarian dibatalkan.");
                    return;
                } else if (jawab  == "no" || jawab == "n")
                {
                    return;
                } else
                {
                    Console.WriteLine("Input tidak valid. Pencarian dibatalkan.");
                    return;
                }
            }
        }

        if (!ditemukan)
        {
            Console.WriteLine("Barang dengan nama tersebut tidak ditemukan.");
        }
    }
}