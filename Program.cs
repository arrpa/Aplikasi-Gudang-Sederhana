public class Program
{
    private static Data data = new Data();
    static void Main()
    {
        Console.Write("Masukkan Username: ");
        string user = Console.ReadLine();
        Console.Write("Masukkan Password: ");
        string pass = Console.ReadLine();

        if (user == "Admin")
        {
            if (pass == "12345")
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Selamat datang!");
                        Console.WriteLine("1. Data barang!");
                        Console.WriteLine("2. Tambah barang!");
                        Console.WriteLine("3. Cari barang!");
                        Console.WriteLine("4. Update barang!");
                        Console.WriteLine("5. Hapus barang!");
                        Console.WriteLine("6. Keluar");
                        Console.Write("Pilih menu (1/2/3/4/5/6): ");
                        int pilihan = int.Parse(Console.ReadLine());

                        switch (pilihan)
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
                                    Update.UpdateBarang(data);
                                    break;
                                case 5:
                                    Hapus.HapusBarang(data);
                                    break;
                                case 6:
                                    Console.WriteLine("Terimakasih sudah menggunakan aplikasi ini!");
                                    return;
                                default:
                                    Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                                    break;
                            }
                    } catch (Exception)
                    {
                        Console.WriteLine("Error: Input tidak valid. Silakan masukkan bilangan bulat antara 1 sampai 5.");
                        continue;
                    }
                }
                
            } else if (pass != "12345")
            {
                Console.WriteLine("Password salah!");
                return;
            }
        }
        else if (user != "Admin" && pass != "12345")
        {
            Console.WriteLine("Username dan Password salah!");
            return;
        } else if (user != "Admin")
        {
            Console.WriteLine("Username salah!");
            return;
        }
    }
}