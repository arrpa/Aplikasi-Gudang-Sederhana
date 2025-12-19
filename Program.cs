public class Program
{
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
                Menu.DisplayMenu();
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