namespace Command.Core;

public class Invoker
{
    private ICommand _onStart;
    private ICommand _onFinish;

    public void SetOnStart(ICommand command)
    {
        this._onStart = command;
    }

    public void SetOnFinish(ICommand command)
    {
        this._onFinish = command;
    }

    public void DoSomethingImportant()
    {
        System.Console.WriteLine("Invoker: Does anybody want something done before I begin?");

        if (this._onStart is ICommand)
        {
            this._onStart.Execute();
        }

        System.Console.WriteLine("Invoker: ...doing something really important...");

        System.Console.WriteLine("Invoker: Does anybody want something done after I finish?");
        if (this._onFinish is ICommand)
        {
            this._onFinish.Execute();
        }
    }
}