using BoSE.patterens;

class Program
{
    public static void Main(string[] args)
    {
        new ClientFactory().Main();
        new ClientAbstractFactory().Main();
    }
}