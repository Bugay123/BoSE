namespace BoSE.patterens;

using System;

public class PBank
  {
    private int balance;

    public PBank()
      {
        balance = 100;
      }

    public void GetBalance()
      {
        Console.WriteLine("PBank balance = " + balance);
      }
  }

public class ABank
  {
    private int balance;

    public ABank()
      {
        balance = 200;
      }

    public void GetBalance()
      {
        Console.WriteLine("ABank balance = " + balance);
      }
  }

public class PBankAdapter : PBank
  {
    private ABank abank;

    public PBankAdapter(ABank abank)
      {
        this.abank = abank;
      }

    public new void GetBalance()
      {
        abank.GetBalance();
      }
  }