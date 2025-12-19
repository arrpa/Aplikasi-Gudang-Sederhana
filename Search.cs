public class Search
{
    public static void CariBarang(Data data)
    {
        while (true)
        {
            Console.WriteLine("=== Pencarian Barang ===");
            Console.WriteLine("1. Cari berdasarkan ID");
            Console.WriteLine("2. Cari berdasarkan Nama");
            Console.WriteLine("3. Kembali ke menu utama");
            Console.Write("Pilih metode pencarian (1/2/3): ");
            int pilihan = int.Parse(Console.ReadLine());

            try
            {
                switch (pilihan)
                {
                    case 1:
                        Searching.ProsesSearchById(data);
                        break;
                    case 2:
                        Searching.ProsesSearchByNam(data);
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