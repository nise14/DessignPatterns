namespace Bridge.Core;

public class ConcreteImplementationA : IImplementation
{
    public string OperationImplementation(){
        return "ConcreteImplementationA: The result in platform A.\n";
    }
}