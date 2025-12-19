// Kelas: Single-25-04
// Kelompok: 01
// Anggota kelompok:
// 1. Ahmad Rizkirich Putra Arif (102042500076)
// 2. Bagas Riyadi (102042500156)
// 3. Rizkia Putri Handayani Rabika (102042500118)
// 4. Atta Rahman Raihannan (102042530017)
// 5. Cindy Jovanna Silitonga (102042500072)

public class Program
{
    static void Main()
    {
        // Laman awal untuk login sederhana dan prosesnya
        Console.WriteLine("-----------------");
        Console.WriteLine("|     Login      |");
        Console.WriteLine("-----------------");
        Console.Write("Masukkan Username: ");
        string user_0401 = Console.ReadLine();
        Console.Write("Masukkan Password: ");
        string pass_0401 = Console.ReadLine();

        // Validasi kridensial
        if (user_0401 == "Admin")
        {
            if (pass_0401 == "12345")
            {
                // Pindah ke file Dashboard dengan memanggil method DisplayMenu
                Menu.DisplayMenu();
            } else if (pass_0401 != "12345")
            {
                Console.WriteLine("Password salah!");
                return;
            }
        }
        else if (user_0401 != "Admin" && pass_0401 != "12345")
        {
            Console.WriteLine("Username dan Password salah!");
            return;
        } else if (user_0401 != "Admin")
        {
            Console.WriteLine("Username salah!");
            return;
        }
    }
}