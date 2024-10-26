namespace u03_extension_metot;

public static class MetinIslemleri 
// static olarak tanımlanmış sınıflarda new etmeden metotlarına ve alanlarına ulaşılabilir
{
    //static bütün üyelerinde statik olması gerekir

    public static string BaslikDuzeni(this string kaynak)
    //extension metot için genişletilen sınıf için this anahtar kelimesi konur
    {
        int index=0;
        string deger = "";

        foreach(char c in kaynak) // "BTK AKADEMİ"
        {
            char c2 = c;

            if(index == 0)
            c2 = char.ToUpper(c);
            else if(kaynak[index-1] == ' ')
            c2 = char.ToUpper(c);

            //Console.Write(c2 + " ");
            deger+=c2;
            index++;
        }

        return deger;
    }
}
