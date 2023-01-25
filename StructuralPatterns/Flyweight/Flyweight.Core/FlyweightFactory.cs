namespace Flyweight.Core;

public class FlyweightFactory
{
    private List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

    public FlyweightFactory(params Car[] args)
    {
        foreach (var elem in args)
        {
            flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), this.GetKey(elem)));
        }
    }

    public string GetKey(Car key)
    {
        List<string> elements = new List<string>();

        elements.Add(key.Model);
        elements.Add(key.Color);
        elements.Add(key.Company);

        if (key.Owner != null && key.Number != null)
        {
            elements.Add(key.Number);
            elements.Add(key.Owner);
        }

        elements.Sort();

        return string.Join("_", elements);
    }

    public Flyweight GetFlyweight(Car sharedState)
    {
        string key = this.GetKey(sharedState);

        if (!flyweights.Any(t => t.Item2 == key))
        {
            Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
            this.flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
        }
        else
        {
            Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
        }

        return this.flyweights.FirstOrDefault(t => t.Item2 == key).Item1;
    }

    public void ListFlyweights()
    {
        int count = flyweights.Count;
        Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");

        foreach (var flyweight in flyweights)
        {
            Console.WriteLine(flyweight.Item2);
        }
    }
}