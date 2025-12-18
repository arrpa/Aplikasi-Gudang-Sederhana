public class Data
{
    public int[] IdBarang = new int[0];    
    public string[] NamaBarang = new string[0];
    public int[] HargaBarang = new int[0];
    public int[] StokBarang = new int[0];
    public enum JenisBarang {edible, nonedible};
    public JenisBarang[] Kategori =  new JenisBarang[0];
    
    private void SizeData()
    {
        int plus = IdBarang.Length + 1;

        int[] newIdBarang = new int[plus];
        string[] newNamaBarang = new string[plus];
        int[]  newHargaBarang = new int[plus];
        int [] newStokBarang = new int[plus];
        JenisBarang[] newKategori = new JenisBarang[plus];

        for (int i = 0; i < IdBarang.Length; i++)
        {
            newIdBarang[i] = IdBarang[i];
            newNamaBarang[i] = NamaBarang[i];
            newHargaBarang[i] = HargaBarang[i];
            newStokBarang[i] = StokBarang[i];
            newKategori[i] = Kategori[i];
        }

        IdBarang = newIdBarang;
        NamaBarang = newNamaBarang; 
        HargaBarang = newHargaBarang;
        StokBarang = newStokBarang;
        Kategori = newKategori;
    }

    public void AddData(int id, string nama, int harga, int stok, JenisBarang kategori)
    {
        SizeData();
        int index = IdBarang.Length - 1;

        IdBarang[index] = id;
        NamaBarang[index] = nama;
        HargaBarang[index] = harga;
        StokBarang[index] = stok;
        Kategori[index] = kategori;
        
    }

    public int GetLength()
    {
        return IdBarang.Length;
    }

    public int CariIndexById(int id)
    {
        for (int i = 0; i < IdBarang.Length; i++)
        {
            if (IdBarang[i] == id)
            {
                return i;
            }
        }
        return -1;
    }
}