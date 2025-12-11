public class Program
{
    static void Main()
    {
        bool status = true;

        Console.Write("Masukkan Username: ");
        string user = Console.ReadLine();
        Console.Write("Masukkan Username: ");
        string pass = Console.ReadLine();

        if (user == "Admin")
        {
            if (pass == "12345")
            {
                while (status)
                {
                    Console.WriteLine("Selamat datang!");
                    Console.WriteLine("1. Data barang!");
                    Console.WriteLine("2. Tambah barang!");
                    Console.WriteLine("3. Update barang!");
                    Console.WriteLine("4. Hapus barang!");
                    Console.WriteLine("5. Keluar");
                    Console.Write("Pilih menu: ");
                    int pilihan = Convert.ToInt32(Console.ReadLine());

                    switch (pilihan)
                        {
                            case 1:
                                status = false;
                                Table.TampilkanData();
                                break;
                            case 2:
                                status = false;
                                Create.TambahBarang();
                                break;
                            case 3:
                                status = false;
                                Update.UpdateBarang();
                                break;
                            case 4:
                                status = false;
                                Hapus.HapusBarang();
                                break;
                            case 5:
                                status = false;
                                Console.WriteLine("Keluar dari program.");
                                break;
                            default:
                                Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                                return;
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