public class Create
{
    public static void TambahBarang(Data data)
    {
        while (true)
        {
            Console.WriteLine("===Tambah barang baru===");
            Table.TampilkanData(data);
            Console.Write("Kembali? (y/n): ");
            string jawab = Console.ReadLine().ToLower();

            if (jawab == "yes" || jawab == "y")
            {
                Console.WriteLine("Penambahan barang dibatalkan.");
                return;
            } else if (jawab  == "no" || jawab == "n")
            {
                try
                {
                    Console.Write("Masukkan ID Barang: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan Nama Barang: ");
                    string nama = Console.ReadLine();
                    Console.Write("Masukkan Harga Barang: ");
                    int harga = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan Stok Barang: ");
                    int stok = int.Parse(Console.ReadLine());
                    Console.Write("Pilih kategori barang (edible/nonedible): ");
                    string pilihan = Console.ReadLine().ToLower();
                    Data.JenisBarang kategori;

                    switch (pilihan)
                    {
                        case "edible":
                            kategori = Data.JenisBarang.edible;
                            break;
                        case "nonedible":
                            kategori = Data.JenisBarang.nonedible;
                            break;
                        default:
                            Console.WriteLine("Error: Kategori tidak valid. Silakan coba lagi.");
                            continue;
                    }

                    int sudahAda = data.CariIndexById(id);
                    if (sudahAda != -1)
                    {
                        Console.WriteLine("Error: ID Barang sudah ada. Silakan gunakan ID yang lain.");
                        continue;
                    }

                    data.AddData(id, nama, harga, stok, kategori);

                    Console.WriteLine("Berhasil menambahkan barang!");
                } catch (Exception)
                {
                    Console.WriteLine("Error: Terjadi kesalahan saat menambahkan barang. Silakan coba lagi.");
                }
            } else
            {
                Console.WriteLine("Input tidak valid. Penambahan barang dibatalkan.");
                continue;
            }
        }

    }

    public static void TampilkanSemuaBarang(Data data)
    {
        Table.TampilkanData(data);
    }
}