using Proxy.Core;

Console.WriteLine("Client: Executing the client code with a real subject:");
RealSubject realSubject = new RealSubject();
ClientCode(realSubject);

Console.WriteLine();

Console.WriteLine("Client: Executing the same client code with a proxy:");
Proxy.Core.Proxy proxy = new Proxy.Core.Proxy(realSubject);
ClientCode(proxy);

void ClientCode(ISubject subject)
{
    // ....
    subject.Request();
    // ...
}