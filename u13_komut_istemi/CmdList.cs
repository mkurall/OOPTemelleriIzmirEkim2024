namespace u13_komut_istemi;

public class CmdList : CommandBase
{
    public override void Execute(IOutputHandler output)
    {
        string path = Directory.GetCurrentDirectory();

        string[] folders = Directory.GetDirectories(path);
        string[] files = Directory.GetFiles(path);

        foreach (string folder in folders)
            output.WriteString(Path.GetFileName(folder));

        foreach (string file in files)
            output.WriteString(Path.GetFileName(file));

    }
}
