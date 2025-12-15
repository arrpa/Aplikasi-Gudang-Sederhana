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
            string jawab = Console.ReadLine();
            jawab = jawab.ToLower();

            if (jawab == "yes" || jawab == "y")
            {
                Console.WriteLine("Gajadi hapus.");
                return;
            } else if (jawab == "no" || jawab == "n")
            {
                // Lanjut disini
            } else
            {
                Console.WriteLine("Tolong input yang benar!");
                continue;
            }
        }
        Console.Write("Masukkan ID Barang yang akan dihapus: ");
        string input = Console.ReadLine();

        Console.WriteLine(input);
        return;
        
    }
}