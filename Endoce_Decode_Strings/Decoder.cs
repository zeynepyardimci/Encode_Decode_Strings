namespace Endoce_Decode_Strings
{
    public class Decoder
    {
        public string[] Decode(string veri)
        {
            string[] geciciSonuc = new string[veri.Length];
            int index = 0;
            int i = 0;
            while(i < veri.Length)
            {
                int j = i;
                while (veri[j] != '#')
                {
                    j++;
                }
                int uzunluk = int.Parse(veri.Substring(i, j-i));
                string kelime = veri.Substring(j+1, uzunluk);
                geciciSonuc[index] = kelime;
                index++;
                i = j+1+uzunluk;
            }
            string[] sonuc = new string[index];
            for(int k=0; k<index; k++)
            {
                sonuc[k] = geciciSonuc[k];
            }
            return sonuc;
        }
    }
}
