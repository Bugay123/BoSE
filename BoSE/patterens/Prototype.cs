namespace BoSE.patterens;

public interface ICopyable
  {
    ICopyable Copy();
  }

public class ComplicatedObject : ICopyable
  {
    public enum Type
      {
        ONE,
        TWO
      }

    private Type type;

    public ICopyable Copy()
      {
        ComplicatedObject complicatedObject = new ComplicatedObject();
        return complicatedObject;
      }

    public void SetType(Type type)
      {
        this.type = type;
        Console.WriteLine(type);
      }
  }