using Decorator.Core;

namespace Decorator.Console;

public class Client
{
    public void ClientCode(Component component)
    {
        System.Console.WriteLine("RESULT: "+ component.Operation());
    }
}