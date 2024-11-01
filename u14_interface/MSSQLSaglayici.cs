
namespace u14_interface;

public class MSSQLSaglayici : IVeritaabaniSaglayici
{
    public void Baglan()
    {
        Console.WriteLine("MSSQL baglantısı oluşturuldu.");
    }

    public void BaglantiyiKes()
    {
        Console.WriteLine("MSSQL baglantısı kapatıldı.");

    }

    public void Guncelle()
    {
        Console.WriteLine("MSSQL veri güncellenedi.");
        
    }

    public void KayitSil(int id)
    {
        Console.WriteLine("MSSQL Kayıt silindi.");
    }

    public object VeriGetir(int id)
    {
        Console.WriteLine("MSSQL veri getirldi.");
        return 0;
    }

    public List<object> VerileriGetir()
    {
        Console.WriteLine("MSSQL vedri listesi getirildi.");

        return new List<object>();
    }
}
