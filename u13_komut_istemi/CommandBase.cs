namespace u13_komut_istemi;

public class CommandBase
{
    public string Name { get; set; }
    public string[] Params { get; set; }

    public virtual void Execute(IOutputHandler output)
    {

    }
}
