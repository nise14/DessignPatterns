using Builder.Method;

Director director = new Director();
ConcreteBuilder builder = new ConcreteBuilder();
director.Builder = builder;

Console.WriteLine("Standard basic product:");
director.BuildMinimalViableProduct();
Console.WriteLine(builder.GetProduct().ListParts());

Console.WriteLine("Standard full feature product:");
director.BuildFullFeaturedProduct();
Console.WriteLine(builder.GetProduct().ListParts());

Console.WriteLine("Custom product:");
builder.BuildPartA();
builder.BuildPartC();
Console.WriteLine(builder.GetProduct().ListParts());