using u02_cok_bicimlilik;

Console.WriteLine("Çokbiçimlilik....");

Sekil sekil1 = new Sekil();

Sekil sekil2 = new Kare() {AKenari = 5};

Sekil sekil3 = new Dortgen() {AKenari = 3, BKenari= 4};


Console.WriteLine($"Şekil1 in Alanı = {sekil1.AlaniHesapla()}");
Console.WriteLine($"Şekil2 in Alanı = {sekil2.AlaniHesapla()}");
Console.WriteLine($"Şekil3 in Alanı = {sekil3.AlaniHesapla()}");



Kare kare = new Kare(){AKenari = 3};

Console.WriteLine($"Karenin A Kenarı= {kare.AKenari}");//get çalışır

kare.AKenari = 5; //set çalışır

