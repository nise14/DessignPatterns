Singleton.Core.Singleton s1 = Singleton.Core.Singleton.GetInstance();
Singleton.Core.Singleton s2 = Singleton.Core.Singleton.GetInstance();

if (s1 == s2)
{
    Console.WriteLine("Singleton works, both variables contain the same instance.");
}
else
{
    Console.WriteLine("Singleton failed, variables contain different instances.");
}