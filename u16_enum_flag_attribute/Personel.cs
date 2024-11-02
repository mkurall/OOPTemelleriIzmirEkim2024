namespace u16_enum_flag_attribute;

public class Personel
{
    public string AdSoyad { get; set; }
    public PersonelTuru Turu { get; set; }
    //0-Yönetici
    //1-Beyaz Yaka
    //2-Mavi Yaka
    //3-Gri Yaka

    public Gunler CalismaGunleri {get; set;}
}

public enum PersonelTuru : int
{
    Yonetici = 0, BeyazYaka = 1, MaviYaka=2, GriYaka=3
}

[Flags]
public enum Gunler
{
    CALISMIYOR = 0, PZT = 1, SAL = 2, CAR = 4, PER=8, CUM=16, CMT=32, PAZ=64,
    HAFTAICI = PZT|SAL|CAR|PER|CUM,
    HAFTASONU = CMT|PAZ
}