namespace u13_komut_istemi;

public class CmdClear : CommandBase
{
    public override void Execute(IOutputHandler output)
    {
        output.Clear();
    }
}
