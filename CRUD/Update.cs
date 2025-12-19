public class Update
{
    public static void UpdateBarang(Data data)
    {
        while (true)
        {
            Console.WriteLine("\n===Update barang===");
            Table.TampilkanData(data);

            Console.Write("\nKembali? (y/n): ");
            string jawab_0401 = Console.ReadLine().ToLower();

            if (jawab_0401 == "yes" || jawab_0401 == "y")
            {
                Console.WriteLine("\nGajadi update.");
                return;
            } else if (jawab_0401 == "no" || jawab_0401 == "n")
            {
                Edit.ProsesEdit(data);
            } 
            else
            {
                Console.WriteLine("\nInput yang benar!");
                continue;
            }
        }
    }
}