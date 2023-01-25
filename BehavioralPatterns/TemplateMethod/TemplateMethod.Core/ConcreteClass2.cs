using System;

namespace TemplateMethod.Core;

public class ConcreteClass2 : AbstractClass
{
    protected override void RequiredOperations1()
    {
        Console.WriteLine("ConcreteClass2 says: Implemented operation1");
    }

    protected override void RequiredOperations2()
    {
        Console.WriteLine("ConcreteClass2 says: Implemented operation2");
    }

    protected override void Hook1()
    {
        Console.WriteLine("ConcreteClass2 says: Override hook1");
    }
}