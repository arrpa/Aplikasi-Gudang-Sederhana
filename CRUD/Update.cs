public class Update
{
    public static void UpdateBarang(Data data)
    {
        while (true)
        {
            Console.WriteLine("===Update barang===");
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
                Console.WriteLine("Gajadi update.");
                return;
            } else if (jawab == "no" || jawab == "n")
            {
                // Lanjut disini
            } else
            {
                Console.WriteLine("Input yang benar!");
                continue;
            }
        }
    }
}