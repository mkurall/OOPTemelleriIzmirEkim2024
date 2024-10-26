namespace u06_generic_list;

public static class ListeIslemleri
{
    public static void AddRange(this List<int> liste, params int[]sayilar)
    {
        liste.AddRange(sayilar);//base üzerindeki AddRange Çağırdım
    }
}
