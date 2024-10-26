
Console.WriteLine("Bir sayı girin:");
int sayi = 0;
bool kontrol = false;

do
{
    try
    {
        sayi = Convert.ToInt32(Console.ReadLine());
       kontrol = true;
    }

    catch(FormatException hata)
    {
        Console.WriteLine("Lütfen sayı girin!"); 
    }
    catch(OverflowException hata)
    {
        Console.WriteLine("Lütfen aralıklara uygun sayı girin!"); 
    }
    catch(Exception hata)
    {
        Console.WriteLine(hata.Message); 
    }

} while(kontrol == false);

Console.WriteLine($"Sayının Karesi = {sayi * sayi}");
