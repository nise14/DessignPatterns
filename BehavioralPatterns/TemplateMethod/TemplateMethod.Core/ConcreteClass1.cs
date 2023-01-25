using System;

namespace TemplateMethod.Core;

public class ConcreteClass1 : AbstractClass
{
    protected override void RequiredOperations1()
    {
        Console.WriteLine("ConcreteClass1 says: Implemented Operation1");
    }

    protected override void RequiredOperations2()
    {
        Console.WriteLine("ConcreteClass1 says: Implemented Operation2");
    }
}