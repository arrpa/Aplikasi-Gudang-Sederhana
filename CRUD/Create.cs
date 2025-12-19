public class Create
{
    public static void TambahBarang(Data data)
    {
        while (true)
        {
            Console.WriteLine("===Tambah barang baru===");
            Table.TampilkanData(data);
            Console.Write("Tambah data? (y/n): ");
            string jawab = Console.ReadLine().ToLower();

            if (jawab == "no" || jawab == "n")
            {
                Console.WriteLine("Penambahan barang dibatalkan.");
                return;
            } else if (jawab  == "yes" || jawab == "y")
            {
                Tambah.ProsesTambah(data);
            } else
            {
                Console.WriteLine("Input tidak valid. Penambahan barang dibatalkan.");
                continue;
            }
        }
    }
}