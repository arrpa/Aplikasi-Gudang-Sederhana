public class Table
{
    public static void TampilkanData(Data data)
    {
        
        Console.WriteLine("Datanya");

        if (data.GetLength() == 0)
        {
            Console.WriteLine("masih belum ada data apapun.");
            return;
        }

        Console.WriteLine("ID\t|Nama\t|Harga\t|Stok");
        for (int i = 0; i < data.GetLength(); i++)
        {
            Console.WriteLine($"{data.IdBarang[i]}\t|{data.NamaBarang[i]}\t|{data.HargaBarang[i]}\t|{data.StokBarang[i]}");
        }
        Console.WriteLine("Filter?");
        
    }
}