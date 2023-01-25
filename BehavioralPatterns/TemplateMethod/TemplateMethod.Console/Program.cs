using TemplateMethod.Core;

static void ClientCode(AbstractClass abstractClass)
{
    abstractClass.TemplateMethod();
}

Console.WriteLine("Same client code can work with different subclasses:");
ClientCode(new ConcreteClass1());

Console.WriteLine("\n");

Console.WriteLine("Same client code can work with different subclasses.");
ClientCode(new ConcreteClass2());