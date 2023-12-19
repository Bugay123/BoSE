namespace BoSE.patterens;

public class Factory
  {
    public OS GetCurrentOS(string inputOS)
      {
        OS os = null;
        if (inputOS.Equals("windows"))
          {
            os = new WindowsOS();
          }
        else if (inputOS.Equals("linux"))
          {
            os = new LinuxOS();
          }
        else if (inputOS.Equals("mac"))
          {
            os = new MacOS();
          }

        return os;
      }
  }

public interface OS
  {
    void GetOS();
  }

public class WindowsOS : OS
  {
    public void GetOS()
      {
        Console.WriteLine("Apply for Windows");
      }
  }

public class LinuxOS : OS
  {
    public void GetOS()
      {
        Console.WriteLine("Apply for Linux");
      }
  }

public class MacOS : OS
  {
    public void GetOS()
      {
        Console.WriteLine("Apply for MacOS");
      }
  }