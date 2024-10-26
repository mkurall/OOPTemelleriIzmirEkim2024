namespace u01_oop_ilk_uygulama;//personel sınıfı bu uzayda olsun

public class Personel
{
    //Fields(alanlar)
    private int id;//dışaıdan erişilemez
    private string ad;
    private string soyad;

    //Properties(Özellikler)
    public int Id { get { return id; } }
    public string Ad { get { return ad; } set { ad = value; } }
    public string Soyad { get { return soyad; } set { soyad = value; } }

    //Constructor (Yapıcı metotlar)
    public Personel(int personelId)
    {
        id = personelId;
    }

    //Methods (metotlar)
    public void Yazdir()
    {
        Console.WriteLine($"{id} - {ad} {soyad}");
    }
}
