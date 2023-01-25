using Adapter.Core;

Adaptee adaptee = new Adaptee();
ITarget target = new Adapter.Core.Adapter(adaptee);

Console.WriteLine("Adaptee interface is incompatible with the client.");
Console.WriteLine("But with adapter client can call it's method.");

Console.WriteLine(target.GetRequest());