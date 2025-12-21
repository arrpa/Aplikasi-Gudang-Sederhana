// Kelas: SI-25-04
// Kelompok: 01
// Anggota kelompok:
// 1. Ahmad Rizkirich Putra Arif (102042500076)
// 2. Bagas Riyadi (102042500156)
// 3. Rizkia Putri Handayani Rabika (102042500118)
// 4. Atta Rahman Raihannan (102042530017)
// 5. Cindy Jovanna Silitonga (102042500072)

public class Data
{
    // Array untuk menyimpan data barang
    public int[] IdBarang_0401 = new int[0];    
    public string[] NamaBarang_0401 = new string[0];
    public int[] HargaBarang_0401 = new int[0];
    public int[] StokBarang_0401 = new int[0];
    public enum JenisBarang_0401 {EDIBLE, NONEDIBLE};
    public JenisBarang_0401[] Kategori_0401 =  new JenisBarang_0401[0];

    // Memperbesar ukuran array data    
    private void SizeData()
    {
        // Hitung ukuran array baru
        int newSize = IdBarang_0401.Length + 1;
    
        // Mengganti referensi array lama dengan array baru
        Array.Resize(ref IdBarang_0401, newSize);
        Array.Resize(ref NamaBarang_0401, newSize);
        Array.Resize(ref HargaBarang_0401, newSize);
        Array.Resize(ref StokBarang_0401, newSize);
        Array.Resize(ref Kategori_0401, newSize);
    }

    // Menambahkan data baru
    public void AddData(int id_0401, string nama_0401, int harga_0401, int stok_0401, JenisBarang_0401 kategori_0401)
    {
        SizeData();
        int index_0401 = IdBarang_0401.Length - 1; // Ambil index terakhir

        // Isi data di slot kosong
        IdBarang_0401[index_0401] = id_0401;
        NamaBarang_0401[index_0401] = nama_0401;
        HargaBarang_0401[index_0401] = harga_0401;
        StokBarang_0401[index_0401] = stok_0401;
        Kategori_0401[index_0401] = kategori_0401;
        
    }

    // Mendapatkan panjang array data
    public int GetLength()
    {
        return IdBarang_0401.Length;
    }

    // Mencari index berdasarkan ID
    public int CariIndexById(int id)
    {
        for (int i = 0; i < IdBarang_0401.Length; i++)
        {
            if (IdBarang_0401[i] == id)
            {
                return i;
            }
        }
        return -1;
    }
}