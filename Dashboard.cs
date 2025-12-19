public class Menu
{
    private static Data data = new Data();
    public static void DisplayMenu()
    {
        Console.WriteLine("Selamat datang di Aplikasi Gudang Sederhana!");
        while (true)
                {
                    try
                    {
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
                        Console.WriteLine("Error: Input tidak valid. Silakan masukkan bilangan bulat antara 1 sampai 7.");
                        continue;
                    }
                }
    }
}