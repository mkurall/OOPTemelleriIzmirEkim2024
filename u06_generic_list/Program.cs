
using u06_generic_list;

List<int> liste = new List<int>();

liste.Add(1);//ekle
//liste.Add("Btk");
//liste.Add(4.5);

liste.AddRange(new int[]{1, 2, 3,});//mevcut metot

liste.AddRange(4, 7, 8, 17, 20, 30);//bizim extension metot
liste.Insert(2, 14);//araya ekle

Console.WriteLine($"Listenin Uzunluğu:{liste.Count}");

foreach (int i in liste)
    Console.WriteLine(i);

