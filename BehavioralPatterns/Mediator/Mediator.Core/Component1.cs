namespace Mediator.Core;

public class Component1 : BaseComponent
{
    public void DoA()
    {
        System.Console.WriteLine("Component 1 does A.");
        this._mediator.Notify(this, "A");
    }

    public void DoB()
    {
        System.Console.WriteLine("Component 1 does B.");
        this._mediator.Notify(this, "B");
    }
}