namespace Command.Core;

public class Complexcommand : ICommand
{
    private Receiver _receiver;

    private string _a;
    private string _b;

    public Complexcommand(Receiver receiver, string a, string b)
    {
        this._receiver = receiver;
        this._a = a;
        this._b = b;
    }

    public void Execute()
    {
        System.Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
        this._receiver.DoSomething(this._a);
        this._receiver.DoSomething(this._b);
    }
}