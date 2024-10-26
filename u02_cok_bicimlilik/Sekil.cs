using System.Reflection;

namespace u02_cok_bicimlilik;

public class Sekil
{
    public virtual double AlaniHesapla()//virtual - Bu metodu sonradan ezmelerine izin veriyorum
    {
        //Alanm hesabını sonraya bırakalım
        return 0;
    }
}

public class Kare : Sekil
{   
     public double AKenari { get; set;} //auto property

    public override double AlaniHesapla()
    {
        return AKenari * AKenari;
    }
}

public class Dortgen: Kare
{
     public double BKenari { get; set;} //auto property

    public override double AlaniHesapla()
    {
        return AKenari * BKenari;
    }

}