// Import library untuk pemudahan buat tabel
using ConsoleTables;

public class Table
{
    public static void TampilkanData(Data data)
    {
        Console.WriteLine("\nData barang di gudang:");
        // Cek apakah data nya ada atau tidak
        if (data.GetLength() == 0)
        {
            Console.WriteLine("Belum ada data barang yang ada.");
            return;
        }
        // Buat tabel untuk meliat semua data berdasarkan array di class Data
        var table = new ConsoleTable("ID", "Nama", "Harga", "Stok", "Jenis Barang");
        for (int i = 0; i < data.GetLength(); i++)
        {
            table.AddRow($"{data.IdBarang_0401[i]}", 
            $"{data.NamaBarang_0401[i]}", 
            $"Rp.{data.HargaBarang_0401[i]}", 
            $"{data.StokBarang_0401[i]}", 
            $"{data.Kategori_0401[i]}");
        }
        table.Configure(o => o.EnableCount = false)
        .Write(Format.Default);
            Console.WriteLine($"\nTotal barang: {data.GetLength()}");
        
    }
}