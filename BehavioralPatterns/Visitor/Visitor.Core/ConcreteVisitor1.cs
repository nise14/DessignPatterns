using System;

namespace Visitor.Core;

public class ConcreteVisitor1 : IVisitor
{
    public void VisitConcreteComponentA(ConcreteComponentA element)
    {
        Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + " ConcreteVisitor1");
    }

    public void VisitConcreteComponentB(ConcreteComponentB element)
    {
        Console.WriteLine(element.SpecialMethodOfConcretComponentB() + " ConcreteVisitor2");
    }
}