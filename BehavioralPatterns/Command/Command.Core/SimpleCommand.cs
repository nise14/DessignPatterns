namespace Command.Core;

public class SimpleCommand : ICommand
{
    private string _payload = string.Empty;

    public SimpleCommand(string payload)
    {
        this._payload = payload;
    }

    public void Execute()
    {
        System.Console.WriteLine($"SimpleCommand: See, I can do simple thinks like printing ({this._payload})");
    }
}