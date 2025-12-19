public class Hapus
{
    public static void HapusBarang(Data data)
    {
        while (true)
        {
            Console.WriteLine("===Hapus barang===");
            Table.TampilkanData(data);
            if (data.GetLength() == 0)
            {
                return;
            }
            Console.Write("Kembali? (y/n): ");
            string jawab = Console.ReadLine().ToLower();

            if (jawab == "yes" || jawab == "y")
            {
                Console.WriteLine("Gajadi hapus.");
                return;
            } else if (jawab == "no" || jawab == "n")
            {
                Delete.ProsesHapus(data);
            } else
            {
                Console.WriteLine("Tolong input yang benar!");
                continue;
            }
        }
    }
}