namespace Factory.Method;
public abstract class Creator
{
    public abstract IProduct FactoryMethod();

    public string SomeOperation()
    {
        IProduct product = FactoryMethod();

        string result = string.Concat("Creator: The same creator's code has just worked with ", product.Operation());
        return result;
    }
}
