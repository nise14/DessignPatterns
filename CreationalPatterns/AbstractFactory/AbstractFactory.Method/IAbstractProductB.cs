namespace AbstractFactory.Method;

public interface IAbstractProductB
{
    string UseFulFunctionB();

    string AnotherUsefulFUnctionB(IAbstractProductA collaborator);
}