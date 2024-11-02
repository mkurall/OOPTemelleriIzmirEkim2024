using u16_enum_flag_attribute;

Personel pers = new Personel();

pers.AdSoyad = "Mustafa KURAL";
pers.Turu = PersonelTuru.MaviYaka;
pers.CalismaGunleri = Gunler.HAFTAICI;

Console.WriteLine($"Ad Soyad:{pers.AdSoyad}");
Console.WriteLine($"Türü:{pers.Turu}");
Console.WriteLine($"Çalışma Günleri:{pers.CalismaGunleri}");

Console.WriteLine($"Türü:{(int)pers.Turu}");
Console.WriteLine($"Çalışma Günleri:{(int)pers.CalismaGunleri}");