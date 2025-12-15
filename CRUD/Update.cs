public class Update
{
    public static void UpdateBarang(Data data)
    {
        while (true)
        {
            Console.WriteLine("===Update barang===");
            Table.TampilkanData(data);
            Console.Write("Kembali? (y/n): ");
            string jawab = Console.ReadLine();
            jawab = jawab.ToLower();

            if (jawab == "yes" || jawab == "y")
            {
                Console.WriteLine("Gajadi update.");
                return;
            } else if (jawab == "no" || jawab == "n")
            {
                
            } else
            {
                Console.WriteLine("Input yang benar!");
                continue;
            }
        }
    }
}