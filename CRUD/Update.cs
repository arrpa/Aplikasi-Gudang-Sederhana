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
                Console.WriteLine("Data barang masih kosong.");
                return;
            }


            Console.Write("Kembali? (y/n): ");
            string jawab = Console.ReadLine().ToLower();

            if (jawab == "yes" || jawab == "y")
            {
                Console.WriteLine("Gajadi update.");
                return;
            } else if (jawab == "no" || jawab == "n")
            {
                Edit.ProsesEdit(data);
            } 
            else
            {
                Console.WriteLine("Input yang benar!");
                continue;
            }
        }
    }
}