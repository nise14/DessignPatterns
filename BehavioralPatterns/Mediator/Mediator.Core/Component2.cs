namespace Mediator.Core;

public class Component2 : BaseComponent
{
    public void DoC()
    {
        System.Console.WriteLine("Component 2 does C.");
        this._mediator.Notify(this, "C");
    }

    public void DoD()
    {
        System.Console.WriteLine("Component 2 does D.");
        this._mediator.Notify(this, "D");
    }
}