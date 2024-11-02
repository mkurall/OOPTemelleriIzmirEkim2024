

using u15_struct;

void Artir1(Sinif sinif)
{
    sinif.X++;
    sinif.Y++;
}


void Artir2(Yapi yapi)
{
    yapi.X++;
    yapi.Y++;
}


Sinif s1 = new Sinif(){X=1, Y=1};//referans tipi (metoda bellek adresi gider )
Yapi y1 = new Yapi() {X=1, Y=1};//deger tipi (mrtoda yeni bir kopyası gider )

Console.WriteLine($"Sınıf X:{s1.X} , Y:{s1.Y}");
Console.WriteLine($"Yapı X:{y1.X} , Y:{y1.Y}");

Artir1(s1);
Artir2(y1);

Console.WriteLine("Metot Çağırma Sonrası");
Console.WriteLine($"Sınıf X:{s1.X} , Y:{s1.Y}");
Console.WriteLine($"Yapı X:{y1.X} , Y:{y1.Y}");