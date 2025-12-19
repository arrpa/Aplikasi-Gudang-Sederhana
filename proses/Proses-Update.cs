public class Edit
{
    public static void ProsesEdit(Data data)
    {
        try
        {
            Console.Write("Masukkan ID barang yang ingin diupdate: ");
            int cariId = int.Parse(Console.ReadLine());

            bool ditemukan = false;

            for (int i = 0; i < data.GetLength(); i++)
            {
                if (data.IdBarang[i] == cariId)
                {
                    Console.WriteLine("Barang Ditemukan");

                    Console.Write("Nama Baru : ");
                    data.NamaBarang[i] = Console.ReadLine();
                            
                    Console.Write("Harga Baru : ");
                    data.HargaBarang[i] = int.Parse(Console.ReadLine());

                    Console.Write("Stok Baru : ");
                    data.StokBarang[i] = int.Parse(Console.ReadLine());

                    Console.Write("Ganti kategori? (y/n): ");
                    string ganti = Console.ReadLine().ToLower();
                    Data.JenisBarang kategori;
                            
                    if (ganti == "yes" || ganti == "y")
                    {
                        if (data.Kategori[i] == Data.JenisBarang.edible)
                        {
                            data.Kategori[i] = Data.JenisBarang.nonedible;
                            return;
                        } else if (data.Kategori[i] == Data.JenisBarang.nonedible)
                        {
                            data.Kategori[i] = Data.JenisBarang.edible;
                            return;
                        } else
                        {
                            Console.WriteLine("Kategori tidak valid. Jenis Barang tidak diubah.");
                            return;
                        }
                    } else if (ganti == "no" || ganti == "n")
                    {
                        Console.WriteLine("Jenis Barang tidak diubah.");
                    } else
                    {
                        Console.WriteLine("Input tidak valid. Jenis Barang tidak diubah.");
                    }

                    ditemukan = true;
                    Console.WriteLine("Data barang berhasil diupdate");
                    break; 
                }
            }

            if (!ditemukan)
            {
                Console.WriteLine("ID Barang tidak ditemukan");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Input harus berupa angka!");
        }
    }
}