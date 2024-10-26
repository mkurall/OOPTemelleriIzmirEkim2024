namespace u13_komut_istemi;

public class Prompt
{
    private void ShowCurrentFolder()
    {
        string folder = Directory.GetCurrentDirectory();

        Console.Write($"{folder}>");
    }
    public string ReadCommand(IInputHandler input)
    {
        ShowCurrentFolder();
        return input.ReadString();
    }
}
