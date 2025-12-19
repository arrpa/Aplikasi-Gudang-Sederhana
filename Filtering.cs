public class Filtering
{
    public static void FilterData(Data data)
    {
        while (true)
        {
            Console.WriteLine("=== Filtering Barang ===");
            Console.WriteLine("1. Edible");
            Console.WriteLine("2. Non-Edible");
            Console.WriteLine("3. Kembali ke menu utama");
            Console.Write("Pilih metode pencarian (1/2/3): ");
            int pilihan = int.Parse(Console.ReadLine());
            switch (pilihan)
            {
                case 1:
                    Filter.ProsesFilterEdible(data);
                    break;
                break;
                case 2:
                    Filter.ProsesFilterNonEdible(data);
                    break;
                break;
                case 3:
                    Console.WriteLine("Kembali ke menu utama.");
                    return;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                break;
            }
        }
    }
}