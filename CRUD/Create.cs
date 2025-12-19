public class Create
{
    public static void TambahBarang(Data data)
    {
        while (true)
        {
            Console.WriteLine("\n===Tambah barang baru===");
            Table.TampilkanData(data);
            Console.Write("\nTambah data? (y/n): ");
            string jawab_0401 = Console.ReadLine().ToLower();

            if (jawab_0401 == "no" || jawab_0401 == "n")
            {
                Console.WriteLine("\nPenambahan barang dibatalkan.");
                return;
            } else if (jawab_0401  == "yes" || jawab_0401 == "y")
            {
                Tambah.ProsesTambah(data);
            } else
            {
                Console.WriteLine("\nInput tidak valid. Penambahan barang dibatalkan.");
                continue;
            }
        }
    }
}