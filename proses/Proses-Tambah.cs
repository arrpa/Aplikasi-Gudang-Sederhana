// Kelas: SI-25-04
// Kelompok: 01
// Anggota kelompok:
// 1. Ahmad Rizkirich Putra Arif (102042500076)
// 2. Bagas Riyadi (102042500156)
// 3. Rizkia Putri Handayani Rabika (102042500118)
// 4. Atta Rahman Raihannan (102042530017)
// 5. Cindy Jovanna Silitonga (102042500072)

public class Tambah
{
    public static void ProsesTambah(Data data)
    {
        try
        {
            Console.Write("Masukkan ID Barang: ");
            int id_0401 = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Nama Barang: ");
            string nama_0401 = Console.ReadLine();
            Console.Write("Masukkan Harga Barang: ");
            int harga_0401 = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Stok Barang: ");
            int stok_0401 = int.Parse(Console.ReadLine());
            Console.Write("Pilih kategori barang (edible/nonedible): ");
            string pilihan_0401 = Console.ReadLine().ToLower();
            Data.JenisBarang_0401 kategori_0401;

            switch (pilihan_0401)
            {
                case "edible":
                    kategori_0401 = Data.JenisBarang_0401.EDIBLE;
                    break;
                case "nonedible":
                    kategori_0401 = Data.JenisBarang_0401.NONEDIBLE;
                    break;
                default:
                    Console.WriteLine("Error: Kategori tidak valid. Silakan coba lagi.");
                    return;
            }

            int sudahAda_0401 = data.CariIndexById(id_0401);
            if (sudahAda_0401 != -1)
            {
                Console.WriteLine("Error: ID Barang sudah ada. Silakan gunakan ID yang lain.");
                return;
            }

            data.AddData(id_0401, nama_0401, harga_0401, stok_0401, kategori_0401);

            Console.WriteLine("Berhasil menambahkan barang!");
        } catch (Exception)
        {
            Console.WriteLine("Error: Terjadi kesalahan saat menambahkan barang. Silakan coba lagi.");
        }
    }
}