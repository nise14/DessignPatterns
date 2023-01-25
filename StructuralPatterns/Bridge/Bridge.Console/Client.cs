using Bridge.Core;

namespace Bridge.Console;

public class Client
{
    public void ClientCode(Abstraction abstraction)
    {
        System.Console.WriteLine(abstraction.Operation());
    }
}