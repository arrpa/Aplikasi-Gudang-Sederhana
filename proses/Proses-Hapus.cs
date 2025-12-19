public class Delete
{
    public static void ProsesHapus(Data data)
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
                Data.JenisBarang[] newKategori = new Data.JenisBarang[newLength];
                int newIndex = 0;
                for (int i = 0; i < data.GetLength(); i++)
                {
                    newIdBarang[newIndex] = data.IdBarang[i];
                    newNamaBarang[newIndex] = data.NamaBarang[i];
                    newHargaBarang[newIndex] = data.HargaBarang[i];
                    newStokBarang[newIndex] = data.StokBarang[i];
                    newKategori[newIndex] = data.Kategori[i];

                    newIndex++;
                }

                data.IdBarang = newIdBarang;
                data.NamaBarang = newNamaBarang;
                data.HargaBarang = newHargaBarang;
                data.StokBarang = newStokBarang;
                data.Kategori = newKategori;

                Console.WriteLine($"Barang dengan ID {TargetId} berhasil dihapus!");
                return;
            } else if (confirm == "n" || confirm == "no")
            {
                Console.WriteLine("Gajadi hapus.");
                return;
            } else 
            {
                Console.WriteLine("Tolong input yang benar!");
                return;
            }
        }
        else
        {
            Console.WriteLine("ID tidak ditemukan. Barang gagal dihapus.");
        }
    }
}