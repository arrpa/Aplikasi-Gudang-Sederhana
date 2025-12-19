public class Tambah
{
    public static void ProsesTambah(Data data)
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
                    return;
            }

            int sudahAda = data.CariIndexById(id);
            if (sudahAda != -1)
            {
                Console.WriteLine("Error: ID Barang sudah ada. Silakan gunakan ID yang lain.");
                return;
            }

            data.AddData(id, nama, harga, stok, kategori);

            Console.WriteLine("Berhasil menambahkan barang!");
        } catch (Exception)
        {
            Console.WriteLine("Error: Terjadi kesalahan saat menambahkan barang. Silakan coba lagi.");
        }
    }
}