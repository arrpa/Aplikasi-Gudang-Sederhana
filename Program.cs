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
                    Console.WriteLine("Selamat datang!");
                    Console.WriteLine("1. Data barang!");
                    Console.WriteLine("2. Tambah barang!");
                    Console.WriteLine("3. Update barang!");
                    Console.WriteLine("4. Hapus barang!");
                    Console.WriteLine("5. Keluar");
                    Console.Write("Pilih menu: ");
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
                                Update.UpdateBarang();
                                break;
                            case 4:
                                Hapus.HapusBarang();
                                break;
                            case 5:
                                Console.WriteLine("Keluar dari program.");
                                return;
                            default:
                                Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                                break;
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