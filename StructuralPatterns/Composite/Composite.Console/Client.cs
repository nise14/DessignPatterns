using Composite.Core;

namespace Composite.Console;

public class Client
{
    public void ClientCode(Component leaf)
    {
        System.Console.WriteLine($"Result: {leaf.Operation()}\n");
    }

    public void ClientCode2(Component component1, Component component2)
    {
        if (component1.IsComposite())
        {
            component1.Add(component2);
        }

        System.Console.WriteLine($"RESULT: {component1.Operation()}");
    }
}