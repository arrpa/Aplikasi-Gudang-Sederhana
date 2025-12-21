// Kelas: SI-25-04
// Kelompok: 01
// Anggota kelompok:
// 1. Ahmad Rizkirich Putra Arif (102042500076)
// 2. Bagas Riyadi (102042500156)
// 3. Rizkia Putri Handayani Rabika (102042500118)
// 4. Atta Rahman Raihannan (102042530017)
// 5. Cindy Jovanna Silitonga (102042500072)

public class Update
{
    public static void UpdateBarang(Data data)
    {
        while (true)
        {
            Console.WriteLine("\n===Update barang===");
            Table.TampilkanData(data);

            Console.Write("\nKembali? (y/n): ");
            string jawab_0401 = Console.ReadLine().ToLower();

            if (jawab_0401 == "yes" || jawab_0401 == "y")
            {
                Console.WriteLine("\nGajadi update.");
                return;
            } else if (jawab_0401 == "no" || jawab_0401 == "n")
            {
                Edit.ProsesEdit(data);
            } 
            else
            {
                Console.WriteLine("\nInput yang benar!");
                continue;
            }
        }
    }
}