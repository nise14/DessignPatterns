namespace Proxy.Core;

public class Proxy : ISubject
{
    private RealSubject _realSubject;

    public Proxy(RealSubject realSubject)
    {
        _realSubject = realSubject;
    }

    public void Request()
    {
        if (this.CheckAccess())
        {
            this._realSubject.Request();
            this.LogAccess();
        }
    }

    public bool CheckAccess()
    {
        System.Console.WriteLine("Proxy: Checking access prior to firing a real request.");
        return true;
    }

    public void LogAccess()
    {
        Console.WriteLine("Proxy: Logging the time of request.");
    }
}