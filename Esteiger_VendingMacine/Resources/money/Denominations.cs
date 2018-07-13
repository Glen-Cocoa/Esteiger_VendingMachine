using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esteiger_VendingMachine.Resources.money
{
  public class Dollar : Currency
  {
    public Dollar()
    {
      this.Name = "Dollar";
      this.Value = 100;
    }
  }

  public class Quarter : Currency
  {
    public Quarter()
    {
      this.Name = "Quarter";
      this.Value = 25;
    }
  }

  public class Dime : Currency
  {
    public Dime()
    {
      this.Name = "Dime";
      this.Value = 10;
    }
  }

  public class Nickel : Currency
  {
    public Nickel()
    {
      this.Name = "Nickel";
      this.Value = 5;

    }
  }
  public class Twenty : Currency
  {
    public Twenty()
    {
      this.Name = "Twenty Dollar Bill";
      this.Value = 2000;
    }
  }
}
