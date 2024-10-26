string masaustuYolu =  Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string btkYolu = Path.Combine(masaustuYolu, "BTK");
string dosyaYolu = Path.Combine(btkYolu,"belge.txt");
string dosyaYolu2 = Path.Combine(btkYolu,"belge2.txt");

File.WriteAllText(dosyaYolu,"Merhaba Dünya!");

File.AppendAllText(dosyaYolu2,"\nBu satır sonradan eklendi...");

string icerik = File.ReadAllText(dosyaYolu2);

Console.WriteLine("İçerik:" + icerik);

if(!Directory.Exists("C:\\BTKAkademi"))
    Directory.CreateDirectory("C:\\BTKAkademi");
    
File.Copy(dosyaYolu2,"C:\\BTKAkademi\\belge.txt");
