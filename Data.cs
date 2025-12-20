public class Data
{
    public int[] IdBarang_0401 = new int[0];    
    public string[] NamaBarang_0401 = new string[0];
    public int[] HargaBarang_0401 = new int[0];
    public int[] StokBarang_0401 = new int[0];
    public enum JenisBarang_0401 {edible, nonedible};
    public JenisBarang_0401[] Kategori_0401 =  new JenisBarang_0401[0];
    
    private void SizeData()
    {
        int plus = IdBarang_0401.Length + 1;

        int[] newIdBarang_0401 = new int[plus];
        string[] newNamaBarang_0401 = new string[plus];
        int[]  newHargaBarang = new int[plus];
        int [] newStokBarang_0401 = new int[plus];
        JenisBarang_0401[] newKategori_0401 = new JenisBarang_0401[plus];

        for (int i = 0; i < IdBarang_0401.Length; i++)
        {
            newIdBarang_0401[i] = IdBarang_0401[i];
            newNamaBarang_0401[i] = NamaBarang_0401[i];
            newHargaBarang[i] = HargaBarang_0401[i];
            newStokBarang_0401[i] = StokBarang_0401[i];
            newKategori_0401[i] = Kategori_0401[i];
        }

        IdBarang_0401 = newIdBarang_0401;
        NamaBarang_0401 = newNamaBarang_0401; 
        HargaBarang_0401 = newHargaBarang;
        StokBarang_0401 = newStokBarang_0401;
        Kategori_0401 = newKategori_0401;
    }

    public void AddData(int id_0401, string nama_0401, int harga_0401, int stok_0401, JenisBarang_0401 kategori_0401)
    {
        SizeData();
        int index_0401 = IdBarang_0401.Length - 1;

        IdBarang_0401[index_0401] = id_0401;
        NamaBarang_0401[index_0401] = nama_0401;
        HargaBarang_0401[index_0401] = harga_0401;
        StokBarang_0401[index_0401] = stok_0401;
        Kategori_0401[index_0401] = kategori_0401;
        
    }

    public int GetLength()
    {
        return IdBarang_0401.Length;
    }

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