namespace u14_interface;

public class HastaneOtomasyonu
{
    IVeritaabaniSaglayici db;

    public HastaneOtomasyonu(IVeritaabaniSaglayici saglayici)
    {
        db = saglayici;
    }

    public void RandevulariGoster()
    {
        db.Baglan();
        db.VerileriGetir();
        Console.WriteLine("Bu günkü randevular....");

        db.BaglantiyiKes();
    }

    public void RandevuOlustur()
    {
        db.Baglan();
        db.Guncelle();
        db.BaglantiyiKes();
    }
}
