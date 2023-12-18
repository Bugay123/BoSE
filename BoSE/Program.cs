using BoSE.patterens;

class Program
{
    public static void Main(string[] args)
    {
        //Factory
        Console.WriteLine("Factory pattern");
        new ClientFactory().Main();
        
        //AbstractFactory
        Console.WriteLine("\nAbstractFactory pattern");
        new ClientAbstractFactory().Main();
        
        //Builder
        // The client code creates a builder object, passes it to the
        // director and then initiates the construction process. The end
        // result is retrieved from the builder object.
        Console.WriteLine("\nBuilder pattern");
        var director = new Director();
        var builder = new ConcreteBuilder();
        director.Builder = builder;

        Console.WriteLine("Standard basic product:");
        director.BuildMinimalViableProduct();
        Console.WriteLine(builder.GetProduct().ListParts());

        Console.WriteLine("Standard full featured product:");
        director.BuildFullFeaturedProduct();
        Console.WriteLine(builder.GetProduct().ListParts());

        // Remember, the Builder pattern can be used without a Director class.
        Console.WriteLine("Custom product:");
        builder.BuildPartA();
        builder.BuildPartC();
        Console.Write(builder.GetProduct().ListParts());
        
        
        //Singletone
        Console.WriteLine("\nSingletone");
        Singleton s1 = Singleton.GetInstance();
        Singleton s2 = Singleton.GetInstance();

        if (s1 == s2)
        {
            Console.WriteLine("Singleton works, both variables contain the same instance.");
        }
        else
        {
            Console.WriteLine("Singleton failed, variables contain different instances.");
        }
    }
}