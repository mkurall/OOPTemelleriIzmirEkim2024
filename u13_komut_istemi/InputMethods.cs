namespace u13_komut_istemi;

class ConsoleInput : IInputHandler
{
    public string ReadString()
    {
        return Console.ReadLine();
    }
}

class ConsoleOutput : IOutputHandler
{
    public void WriteString(string str)
    {
        Console.WriteLine(str);
    }
    public void Clear()
    {
        Console.Clear();
    }
}

class NetworkInput : IInputHandler
{
    public string ReadString()
    {
        //ağa bağlan
        //veriyi dinle
        //veriyi al
        return "";
    }
}

