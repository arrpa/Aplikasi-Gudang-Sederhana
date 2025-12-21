// Kelas: SI-25-04
// Kelompok: 01
// Anggota kelompok:
// 1. Ahmad Rizkirich Putra Arif (102042500076)
// 2. Bagas Riyadi (102042500156)
// 3. Rizkia Putri Handayani Rabika (102042500118)
// 4. Atta Rahman Raihannan (102042530017)
// 5. Cindy Jovanna Silitonga (102042500072)

public class Edit
{
    public static void ProsesEdit(Data data)
    {
        try
        {
            Console.Write("\nMasukkan ID barang yang ingin diupdate: ");
            int cariId_0401 = int.Parse(Console.ReadLine());

            bool ditemukan_0401 = false;

            for (int i = 0; i < data.GetLength(); i++)
            {
                if (data.IdBarang_0401[i] == cariId_0401)
                {
                    Console.WriteLine("Barang Ditemukan");

                    Console.Write("Nama Baru : ");
                    data.NamaBarang_0401[i] = Console.ReadLine();
                            
                    Console.Write("Harga Baru : ");
                    data.HargaBarang_0401[i] = int.Parse(Console.ReadLine());

                    Console.Write("Stok Baru : ");
                    data.StokBarang_0401[i] = int.Parse(Console.ReadLine());

                    Console.Write("Ganti kategori? (y/n): ");
                    string ganti_0401 = Console.ReadLine().ToLower();
                    Data.JenisBarang_0401 kategori_0401;
                            
                    if (ganti_0401 == "yes" || ganti_0401 == "y")
                    {
                        if (data.Kategori_0401[i] == Data.JenisBarang_0401.EDIBLE)
                        {
                            data.Kategori_0401[i] = Data.JenisBarang_0401.NONEDIBLE;
                            return;
                        } else if (data.Kategori_0401[i] == Data.JenisBarang_0401.NONEDIBLE)
                        {
                            data.Kategori_0401[i] = Data.JenisBarang_0401.EDIBLE;
                            return;
                        } else
                        {
                            Console.WriteLine("Kategori tidak valid. Jenis Barang tidak diubah.");
                            return;
                        }
                    } else if (ganti_0401 == "no" || ganti_0401 == "n")
                    {
                        Console.WriteLine("Jenis Barang tidak diubah.");
                    } else
                    {
                        Console.WriteLine("Input tidak valid. Jenis Barang tidak diubah.");
                    }

                    ditemukan_0401 = true;
                    Console.WriteLine("Data barang berhasil diupdate");
                    break; 
                }
            }

            if (!ditemukan_0401)
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