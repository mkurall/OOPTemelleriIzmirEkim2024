using System.Collections;
using u05_koleksiyonlar;

//array list içindeki herşey bir objectir.
ArrayList arrayList = new ArrayList();

arrayList.Add(3);//ekelemek
arrayList.Add("Btk");
arrayList.Add(true);
arrayList.Add(new Personel() { Ad = "Kerem", Soyad="Koyuncu"});

Personel p = (Personel)arrayList[3];
int sayi = (int)arrayList[0];

arrayList.RemoveAt(2);//silmek

foreach(object elem in arrayList)
{
    Console.WriteLine(elem);
}

