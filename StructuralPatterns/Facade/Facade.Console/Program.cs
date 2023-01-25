using Facade.Core;

Subsystem1 subsystem1 = new Subsystem1();
Subsystem2 subsystem2 = new Subsystem2();
Facade.Core.Facade facade = new Facade.Core.Facade(subsystem1, subsystem2);
ClientCode(facade);

void ClientCode(Facade.Core.Facade facade)
{
    Console.WriteLine(facade.Operation());
}

