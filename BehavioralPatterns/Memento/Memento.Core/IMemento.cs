namespace Memento.Core;

public interface IMemento
{
    string GetName();

    string GetState();

    DateTime GetDate();
}