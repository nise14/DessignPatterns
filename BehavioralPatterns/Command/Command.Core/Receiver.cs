namespace Command.Core;

public class Receiver
{
    public void DoSomething(string a)
    {
        System.Console.WriteLine($"Receiver: Working on ({a}.)");
    }

    public void DoSomethingElse(string b)
    {
        System.Console.WriteLine($"Receiver: Also Working on ({b}.)");
    }
}