using System.Text.Json;

namespace Flyweight.Core;

public class Flyweight
{
    private Car _sharedState;

    public Flyweight(Car car)
    {
        this._sharedState = car;
    }

    public void Operation(Car uniqueState)
    {
        string s = JsonSerializer.Serialize(this._sharedState);
        string u = JsonSerializer.Serialize(uniqueState);

        Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
    }
}