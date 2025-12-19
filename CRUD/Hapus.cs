public class Hapus
{
    public static void HapusBarang(Data data)
    {
        while (true)
        {
            Console.WriteLine("\n===Hapus barang===");
            Table.TampilkanData(data);
            if (data.GetLength() == 0)
            {
                return;
            }
            Console.Write("\nKembali? (y/n): ");
            string jawab_0401 = Console.ReadLine().ToLower();

            if (jawab_0401 == "yes" || jawab_0401 == "y")
            {
                Console.WriteLine("\nGajadi hapus.");
                return;
            } else if (jawab_0401 == "no" || jawab_0401 == "n")
            {
                Delete.ProsesHapus(data);
            } else
            {
                Console.WriteLine("\nTolong input yang benar!");
                continue;
            }
        }
    }
}