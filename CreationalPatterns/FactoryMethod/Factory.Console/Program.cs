using Factory.Method;

void ClientCode(Creator creator)
{
    Console.WriteLine(creator.SomeOperation());
}

Console.WriteLine("App: Launched with the ConcreteCreator1");
ClientCode(new ConcreteCreator1());
Console.WriteLine("");
Console.WriteLine("App: Launched with the ConcreteCreator2");
ClientCode(new ConcreteCreator2());
