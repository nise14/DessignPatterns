namespace Proxy.Core;

public class RealSubject : ISubject
{
    public void Request()
    {
        System.Console.WriteLine("RealSubject: Handling Request.");
    }
}