using System;
using AbstractFactory.Method;

void ClientMethod(IAbstractFactory factory)
{
    var productA = factory.CreateProductA();
    var productB = factory.CreateProductB();

    Console.WriteLine(productB.UseFulFunctionB());
    Console.WriteLine(productB.AnotherUsefulFUnctionB(productA));
}

Console.WriteLine("Client: Testing client code with the first factory type...");
ClientMethod(new ConcreteFactory1());
Console.WriteLine();
Console.WriteLine("Client: Testing client code with the second factory type...");
ClientMethod(new ConcreteFactory2());