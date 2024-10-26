string yol1 = "C:\\Users\\";
string yol2 = "Belgeler\\dosya.txt";

string yol3 = Path.Combine(yol1, yol2);

Console.WriteLine("Path:" + yol3);

Console.WriteLine("DirectoryName:" + Path.GetDirectoryName(yol3));
Console.WriteLine("FileName:" + Path.GetFileName(yol3));
Console.WriteLine("Extension:" + Path.GetExtension(yol3));
