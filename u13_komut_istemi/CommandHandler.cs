using System.Runtime.InteropServices;

namespace u13_komut_istemi;

public static class CommandHandler
{
    static Prompt prompt = new Prompt();
    public static void Run(IInputHandler input, IOutputHandler output)
    {
        string cmd;

        output.WriteString("Komut İstemi Uygulaması 1.0");
        do
        {
            cmd = prompt.ReadCommand(input);

            //Komutu işleyecek 
            if(cmd == "clear")
            {
                CmdClear command = new CmdClear();
                command.Execute(output);
            }
            else if(cmd == "ls")
            {
                CmdList command = new CmdList();
                command.Execute(output);
            }

        } while(cmd != "quit");
    }
}
