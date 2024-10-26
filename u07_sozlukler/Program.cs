using System.Runtime.InteropServices;

Dictionary<int, string> liste = new Dictionary<int, string>();

liste.Add(1, "Adana");
liste.Add(6,"Ankara");
liste.Add(34, "İstanbul");
liste.Add(35, "İzmir");

//liste.Add(99, "Adana");

liste[10] = "Balıkesir";//10 index değil
liste[9] = "Aydın";

Console.WriteLine(liste[35]);//35 anahtarına karşılık gelen değer

foreach(var elem in liste)
{
    Console.WriteLine($"Anahtar: {elem.Key} Değer: {elem.Value}");
}




