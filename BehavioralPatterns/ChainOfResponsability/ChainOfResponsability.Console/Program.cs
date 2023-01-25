using ChainOfResponsability.Core;

void ClientCode(AbstractHandler handler)
{
    foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee" })
    {
        Console.WriteLine($"Client: Who wants of {food}?");

        var result = handler.Handle(food);

        if (result != null)
        {
            Console.Write($"   {result}");
        }
        else
        {
            Console.WriteLine($"   {food} was left untouched.");
        }
    }
}

var monkey = new MonkeyHandler();
var squirrel = new SquirrelHanlder();
var dog = new DogHandler();

monkey.SetNext(squirrel).SetNext(dog);

Console.WriteLine("Chain: Moneky > Squirrel > Dog\n");
ClientCode(monkey);
Console.WriteLine();

Console.WriteLine("Subchain: Squirrel > Dog\n");
ClientCode(squirrel);