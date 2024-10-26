string[] klasorler = Directory.GetDirectories("C:\\");

foreach(string klasor in klasorler)
{
    Console.WriteLine(klasor);
}

if(!Directory.Exists("C:\\BTKAkdemi"))
{
    Directory.CreateDirectory("C:\\BTKAkademi");
}

Directory.Delete("C:\\BTKAkademi");

string masaustuYolu =  Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

Console.WriteLine("Masaüstü: " + masaustuYolu);

Directory.CreateDirectory(Path.Combine(masaustuYolu,"BTK"));