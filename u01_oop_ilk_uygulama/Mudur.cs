﻿namespace u01_oop_ilk_uygulama;

//Kalıtım
public class Mudur : Personel      //mudur = this, personel = base
{
    private int calisanSayisi = 0;
    Personel[] calisanlar = new Personel[10];
    public Mudur(int id) : base(id)//new Personel(id)  //önce Personel oluşturulsun
    {
        Console.WriteLine("Müdür yapıcı metodu çalıştı.");
    }

    public void CalisanEkle(Personel p)
    {
        if(calisanSayisi>=calisanlar.Length)
        {
            Console.WriteLine("Yeni personle eklenemez. Sınır doldu.");
        }
        calisanlar[calisanSayisi] = p;
        calisanSayisi++;
    }

    public void CalisanlariListele()
    {
        Console.WriteLine($"{Ad} {Soyad} altında çalışan personleller:");
        for(int i=0; i < calisanSayisi;i++)
        {
            calisanlar[i].Yazdir();
        }
    }

    public override void Yazdir() //virtual ----> override
    {
        Console.WriteLine($"{Id} - {Ad} {Soyad} - Müdür");
    }
}
