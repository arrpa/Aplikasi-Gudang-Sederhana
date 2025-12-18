public class Hapus
{
    public static void HapusBarang(Data data)
    {
        while (true)
        {
            Console.WriteLine("===Hapus barang===");
            Table.TampilkanData(data);
            if (data.GetLength() == 0)
            {
                return;
            }
            Console.Write("Kembali? (y/n): ");
            string jawab = Console.ReadLine().ToLower();

            if (jawab == "yes" || jawab == "y")
            {
                Console.WriteLine("Gajadi hapus.");
                return;
            } else if (jawab == "no" || jawab == "n")
            {
                Console.Write("Masukkan ID barang yang ingin dihapus: ");
                int TargetId = int.Parse(Console.ReadLine());

                if (TargetId == data.CariIndexById(TargetId))
                {
                    int index = data.CariIndexById(TargetId);
                    Console.WriteLine($"ID: {data.IdBarang[index]}, Nama: {data.NamaBarang[index]} akan dihapus dari data beserta isinya");
                    Console.Write("Yakin? (y/n): ");
                    string confirm = Console.ReadLine().ToLower();
                    if (confirm != "y" && confirm != "yes")
                    {
                        int newLength = data.GetLength() - 1;
                        int[] newIdBarang = new int[newLength];
                        string[] newNamaBarang = new string[newLength];
                        int[] newHargaBarang = new int[newLength];
                        int[] newStokBarang = new int[newLength];
                        int newIndex = 0;
                        for (int i = 0; i < data.GetLength(); i++)
                        {
                            newIdBarang[newIndex] = data.IdBarang[i];
                            newNamaBarang[newIndex] = data.NamaBarang[i];
                            newHargaBarang[newIndex] = data.HargaBarang[i];
                            newStokBarang[newIndex] = data.StokBarang[i];

                            newIndex++;
                        }

                        data.IdBarang = newIdBarang;
                        data.NamaBarang = newNamaBarang;
                        data.HargaBarang = newHargaBarang;
                        data.StokBarang = newStokBarang;

                        Console.WriteLine($"Barang dengan ID {TargetId} berhasil dihapus!");
                        return;
                    } else if (confirm == "n" || confirm == "no")
                    {
                        Console.WriteLine("Gajadi hapus.");
                        return;
                    } else 
                    {
                        Console.WriteLine("Tolong input yang benar!");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("ID tidak ditemukan. Barang gagal dihapus.");
                }

            } else
            {
                Console.WriteLine("Tolong input yang benar!");
                continue;
            }
        }
    }
}