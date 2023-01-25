namespace Visitor.Core;

public class ConcreteComponentB : IComponent
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteComponentB(this);
    }

    public string SpecialMethodOfConcretComponentB()
    {
        return "B";
    }
}