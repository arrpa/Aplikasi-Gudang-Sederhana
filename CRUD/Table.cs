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

        Console.WriteLine("|ID\t|Nama\t|Harga\t|Stok\t|Jenis Barang");
        for (int i = 0; i < data.GetLength(); i++)
        {
            Console.WriteLine($"{data.IdBarang[i]}\t|{data.NamaBarang[i]}\t|Rp.{data.HargaBarang[i]}\t|{data.StokBarang[i]}\t|{data.Kategori[i]}");
        }
        
    }
}