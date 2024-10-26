using System.Runtime.InteropServices;

namespace u13_komut_istemi;

public static class CommandHandler
{
    static Prompt prompt = new Prompt();
    public static void Execute(IInputHandler input, IOutputHandler output)
    {
        string cmd;

        output.WriteString("Komut İstemi Uygulaması 1.0");
        do
        {
            cmd = prompt.ReadCommand(input);
            //Komutu işleyecek 

        } while(cmd != "quit");
    }
}
