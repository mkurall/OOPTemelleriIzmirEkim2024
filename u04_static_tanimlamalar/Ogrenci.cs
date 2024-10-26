namespace u04_static_tanimlamalar;

public class Ogrenci
{
    private int okunanKitapSayisi  = 0; //instance
    private static int toplamOkunanKitapSayisi = 0;

    public string AdSoyad { get; set; }//auto property
    public int OkunanKitapSayisi {get {return okunanKitapSayisi;}} 
    public static int ToplamOkunanKitapSayisi {get {return toplamOkunanKitapSayisi;}} 

    public void KitapOku()
    {
        Console.WriteLine($"{AdSoyad} adlı öğrenci kitap okudu.");
        okunanKitapSayisi++;//ogrenciye ait
        toplamOkunanKitapSayisi++;//ortak alan
    }
}
