namespace AbstractFactory.Method;

public class ConcreteProductB2 : IAbstractProductB
{
    public string UseFulFunctionB()
    {
        return "The result of the product B2.";
    }


    public string AnotherUsefulFUnctionB(IAbstractProductA collaborator)
    {
        var result = collaborator.UseFulFunctionA();

        return $"The result of B2 collaborating with the ({result})";
    }
}