namespace Facade.Core;

public class Facade
{
    protected Subsystem1 _subsystem1;
    protected Subsystem2 _subsystem2;

    public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
    {
        this._subsystem1 = subsystem1;
        this._subsystem2 = subsystem2;
    }

    public string Operation()
    {
        string result = "Facae initializes subsystems:\n";
        result += this._subsystem1.Operation1();
        result += this._subsystem2.Operation1();
        result += "Facade orders subsystems to perform the action:\n";
        result += this._subsystem1.OperationN();
        result += this._subsystem2.OperationZ();
        return result;
    }
}