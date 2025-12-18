public class Data
{
    public int[] IdBarang = new int[0];    
    public string[] NamaBarang = new string[0];
    public int[] HargaBarang = new int[0];
    public int[] StokBarang = new int[0];
    
    private void SizeData()
    {
        int plus = IdBarang.Length + 1;

        int[] newIdBarang = new int[plus];
        string[] newNamaBarang = new string[plus];
        int[]  newHargaBarang = new int[plus];
        int [] newStokBarang = new int[plus];

        for (int i = 0; i < IdBarang.Length; i++)
        {
            newIdBarang[i] = IdBarang[i];
            newNamaBarang[i] = NamaBarang[i];
            newHargaBarang[i] = HargaBarang[i];
            newStokBarang[i] = StokBarang[i];
        }

        IdBarang = newIdBarang;
        NamaBarang = newNamaBarang; 
        HargaBarang = newHargaBarang;
        StokBarang = newStokBarang;
    }

    public void AddData(int id, string nama, int harga, int stok)
    {
        SizeData();
        int index = IdBarang.Length - 1;

        IdBarang[index] = id;
        NamaBarang[index] = nama;
        HargaBarang[index] = harga;
        StokBarang[index] = stok;
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