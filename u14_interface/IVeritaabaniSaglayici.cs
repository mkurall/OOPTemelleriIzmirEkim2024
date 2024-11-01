namespace u14_interface;

public interface IVeritaabaniSaglayici
{
    void Baglan();
    void BaglantiyiKes();
    List<object> VerileriGetir();
    object VeriGetir(int id);
    void KayitSil(int id);
    void Guncelle();
}
