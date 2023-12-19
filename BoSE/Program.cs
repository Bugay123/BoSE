using BoSE.patterens;

class Program
  {
    public static void Main(string[] args)
      {
        //Factory
        Console.WriteLine("Factory pattern");
        Factory factory = new Factory();
        OS os = factory.GetCurrentOS("linux");
        os.GetOS();

        //AbstractFactory
        Console.WriteLine("\nAbstractFactory pattern");
        string country = "UA";
        ICarPriceAbstractFactory factoryTest = null;

        if (country.Equals("UA"))
          {
            factoryTest = new UaCarPriceAbstractFactory();
          }
        else if (country.Equals("EU"))
          {
            factoryTest = new EuCarPriceAbstractFactory();
          }

        IZaz zaz = factoryTest.GetZaz();
        Console.WriteLine(zaz.GetZazPrice());

        //Builder
        Console.WriteLine("\nBuilder pattern");
        Build build = new Build(1);
        build.BuildCar();

        //Singletone
        Console.WriteLine("\nSingletone");
        Singleton s1 = Singleton.Instance;
        s1.SetUp();
        
        //Prototype
        Console.WriteLine("\nPrototype");
        ComplicatedObject prototype = new ComplicatedObject();
        ComplicatedObject clone = (ComplicatedObject)prototype.Copy();
        clone.SetType(ComplicatedObject.Type.ONE);
        
        
      }
  }