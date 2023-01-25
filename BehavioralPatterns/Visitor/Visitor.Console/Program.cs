using Visitor.Core;

void ClientCode(List<IComponent> components, IVisitor visitor)
{
    foreach (var component in components)
    {
        component.Accept(visitor);
    }
}

List<IComponent> components = new List<IComponent>{
    new ConcreteComponentA(),
    new ConcreteComponentB()
};

Console.WriteLine("The client code works with all visitor via the base visitor interface");
var visitor1 = new ConcreteVisitor1();
ClientCode(components, visitor1);

Console.WriteLine();

Console.WriteLine("It allows the same client code to works with different types of visitors");
var visitor2 = new ConcreteVisitor2();
ClientCode(components, visitor2);