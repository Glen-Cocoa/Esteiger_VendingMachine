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
      this.Weight = 100;
    }
  }

  public class Quarter : Currency
  {
    public Quarter()
    {
      this.Name = "Quarter";
      this.Weight = 25;
    }
  }

  public class Dime : Currency
  {
    public Dime()
    {
      this.Name = "Dime";
      this.Weight = 10;
    }
  }

  public class Nickel : Currency
  {
    public Nickel()
    {
      this.Name = "Nickel";
      this.Weight = 5;

    }
  }
}
