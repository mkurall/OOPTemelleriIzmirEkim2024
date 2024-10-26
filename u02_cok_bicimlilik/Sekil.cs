using System.Reflection;

namespace u02_cok_bicimlilik2
{

internal class Sekil
{
    protected double pi = 3.14;
    public virtual double AlaniHesapla()//virtual - Bu metodu sonradan ezmelerine izin veriyorum
    {
        //Alanm hesabını sonraya bırakalım
        return 0;
    }
}

internal class Kare : Sekil
{   
     public double AKenari { get; set;} //auto property

    public override double AlaniHesapla()
    {
        return AKenari * AKenari;
    }
}

internal class Dortgen: Kare
{
    public double BKenari { get; set;} //auto property

    public override double AlaniHesapla()
    {
        
        return AKenari * BKenari;
    }

}

internal class Cember : Sekil
{
    public double YariCap { get; set;}
    public override double AlaniHesapla()
    {
        return pi * YariCap * YariCap;
    }
}
}