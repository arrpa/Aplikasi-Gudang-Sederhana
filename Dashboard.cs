// Kelas: SI-25-04
// Kelompok: 01
// Anggota kelompok:
// 1. Ahmad Rizkirich Putra Arif (102042500076)
// 2. Bagas Riyadi (102042500156)
// 3. Rizkia Putri Handayani Rabika (102042500118)
// 4. Atta Rahman Raihannan (102042530017)
// 5. Cindy Jovanna Silitonga (102042500072)

public class Menu
{
    // Panggil semua class Data untuk nanti digunakan di semua fungsu dan menu
    private static Data data = new Data();
    public static void DisplayMenu()
    {
        Console.WriteLine("Selamat datang di Aplikasi Gudang Sederhana!");
        while (true)
                {
                    try
                    {
                        // Tampilan menu utama
                        Console.WriteLine("\n=== Menu Utama ===!");
                        Console.WriteLine("1. Data barang");
                        Console.WriteLine("2. Tambah barang");
                        Console.WriteLine("3. Cari barang");
                        Console.WriteLine("4. Filter barang");
                        Console.WriteLine("5. Update barang");
                        Console.WriteLine("6. Hapus barang");
                        Console.WriteLine("7. Keluar");
                        Console.Write("Pilih menu (1/2/3/4/5/6/7): ");
                        int pilihan_0401 = int.Parse(Console.ReadLine());

                        // Panggil semua class sesuai dengan pilihan menu dengan tambahan method Data
                        switch (pilihan_0401)
                            {
                                case 1:
                                    Table.TampilkanData(data);
                                    break;
                                case 2:
                                    Create.TambahBarang(data);
                                    break;
                                case 3:
                                    Search.CariBarang(data);
                                    break;
                                case 4:
                                    Filtering.FilterData(data);
                                    break;
                                case 5:
                                    Update.UpdateBarang(data);
                                    break;
                                case 6:
                                    Hapus.HapusBarang(data);
                                    break;
                                case 7:
                                    Console.WriteLine("Terimakasih sudah menggunakan aplikasi ini!");
                                    return;
                                default:
                                    Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                                    break;
                            }
                    } catch (Exception)
                    {
                        // Menangkap error jika input bukan bilangan bulat
                        Console.WriteLine("Error: Input tidak valid. Silakan masukkan bilangan bulat antara 1 sampai 7.");
                        continue;
                    }
                }
    }
}