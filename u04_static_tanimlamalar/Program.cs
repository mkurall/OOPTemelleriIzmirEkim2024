using u04_static_tanimlamalar;

Ogrenci ogr1 = new Ogrenci(){AdSoyad="1.Öğrenci"};
Ogrenci ogr2 = new Ogrenci(){AdSoyad="2.Öğrenci"};
Ogrenci ogr3 = new Ogrenci(){AdSoyad="3.Öğrenci"};
Ogrenci ogr4 = new Ogrenci(){AdSoyad="4.Öğrenci"};

ogr1.KitapOku();
ogr2.KitapOku();
ogr1.KitapOku();
ogr3.KitapOku();

Console.WriteLine($"{ogr1.AdSoyad} okunan kitap sayısı = {ogr1.OkunanKitapSayisi}");
Console.WriteLine($"{ogr2.AdSoyad} okunan kitap sayısı = {ogr2.OkunanKitapSayisi}");
Console.WriteLine($"{ogr3.AdSoyad} okunan kitap sayısı = {ogr3.OkunanKitapSayisi}");
Console.WriteLine($"{ogr4.AdSoyad} okunan kitap sayısı = {ogr4.OkunanKitapSayisi}");

Console.WriteLine($"Toplam okunan kitap sayısı = {Ogrenci.ToplamOkunanKitapSayisi}");
