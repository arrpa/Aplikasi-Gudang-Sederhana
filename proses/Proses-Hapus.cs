public class Delete
{
    public static void ProsesHapus(Data data)
    {
        Console.Write("\nMasukkan ID barang yang ingin dihapus: ");
        int TargetId_0401 = int.Parse(Console.ReadLine());

        int index_0401 = data.CariIndexById(TargetId_0401);
        if (index_0401 == -1)
        {
            Console.WriteLine("ID tidak ditemukan. Barang gagal dihapus.");
            return;
        }

        Console.WriteLine($"ID: Produk: {data.NamaBarang_0401[index_0401]} akan dihapus dari data beserta isinya");
        Console.Write("Yakin? (y/n): ");
        string confirm_0401 = Console.ReadLine().ToLower();

        if (confirm_0401 == "y" || confirm_0401 == "yes")
        {
            int newLength = data.GetLength() - 1;
            int[] newIdBarang_0401 = new int[newLength];
            string[] newNamaBarang_0401 = new string[newLength];
            int[] newHargaBarang_0401 = new int[newLength];
            int[] newStokBarang_0401 = new int[newLength];
            Data.JenisBarang_0401[] newKategori_0401 = new Data.JenisBarang_0401[newLength];
            int newIndex = 0;
            for (int i = 0; i < data.GetLength(); i++)
            {
                if (i == index_0401)
                {
                    continue;
                }
                newIdBarang_0401[newIndex] = data.IdBarang_0401[i];
                newNamaBarang_0401[newIndex] = data.NamaBarang_0401[i];
                newHargaBarang_0401[newIndex] = data.HargaBarang_0401[i];
                newStokBarang_0401[newIndex] = data.StokBarang_0401[i];
                newKategori_0401[newIndex] = data.Kategori_0401[i];

                newIndex++;
            }

            data.IdBarang_0401 = newIdBarang_0401;
            data.NamaBarang_0401 = newNamaBarang_0401;
            data.HargaBarang_0401 = newHargaBarang_0401;
            data.StokBarang_0401 = newStokBarang_0401;
            data.Kategori_0401 = newKategori_0401;

            Console.WriteLine($"Barang dengan ID {TargetId_0401} berhasil dihapus!");
            return;
        } else if (confirm_0401 == "n" || confirm_0401 == "no")
        {
            Console.WriteLine("Gajadi hapus.");
            return;
        } else 
        {
            Console.WriteLine("Tolong input yang benar!");
            return;
        }
    }
}