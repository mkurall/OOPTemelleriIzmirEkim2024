
using u01_oop_ilk_uygulama;//personel sınıfının uzayını kullan

Personel p1 = new Personel(1);//bellekten p1 için yer ayır
p1.Ad = "Hasan";
p1.Soyad = "DEMİR";

Personel p2 = new Personel(2) { Ad = "Ayşe", Soyad = "CAN"};

//p1.Id = 5; Id sadece okunabilir olduğu için değiştirilemez
p1.Ad = "Mehmet";


Console.WriteLine("Personel1'in Bilgileri");
p1.Yazdir();

Console.WriteLine("\n\nPersonel2'in Bilgileri");
p2.Yazdir();


Mudur mudur = new Mudur(3);//idsi olmayan personel oluştu
