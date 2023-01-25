namespace AbstractFactory.Method;

public class ConcreteProductB1 : IAbstractProductB
{
    public string UseFulFunctionB()
    {
        return "The result of the product B1.";
    }


    public string AnotherUsefulFUnctionB(IAbstractProductA collaborator)
    {
        var result = collaborator.UseFulFunctionA();

        return $"The result of B1 collaborating with the ({result})";
    }
}