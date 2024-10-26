namespace u05_koleksiyonlar;

public class Personel : object
{
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public override string ToString()
    {
        return Ad + " " + Soyad;
    }
}
