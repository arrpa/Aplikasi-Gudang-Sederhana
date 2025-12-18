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
            else
            {
                Console.WriteLine("Input yang benar!");
                continue;
            }
        }
    }
}