namespace u14_interface;

public class OracleSaglayici : IVeritaabaniSaglayici
{
 public void Baglan()
    {
        Console.WriteLine("Oracle baglantısı oluşturuldu.");
    }

    public void BaglantiyiKes()
    {
        Console.WriteLine("Oracle baglantısı kapatıldı.");

    }

    public void Guncelle()
    {
        Console.WriteLine("Oracle veri güncellenedi.");
        
    }

    public void KayitSil(int id)
    {
        Console.WriteLine("Oracle Kayıt silindi.");
    }

    public object VeriGetir(int id)
    {
        Console.WriteLine("Oracle veri getirldi.");
        return 0;
    }

    public List<object> VerileriGetir()
    {
        Console.WriteLine("Oracle vedri listesi getirildi.");

        return new List<object>();
    }
}
