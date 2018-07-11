using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esteiger_VendingMachine.Resources.money
{
  class Dollar : CurrencyAbstract
  {
    public Dollar()
    {
      this.Name = "Dollar";
      this.Weight = 100;
    }
  }

  class Quarter : CurrencyAbstract
  {
    public Quarter()
    {
      this.Name = "Quarter";
      this.Weight = 25;
    }
  }

  class Dime : CurrencyAbstract
  {
    public Dime()
    {
      this.Name = "Dime";
      this.Weight = 10;
    }
  }

  class Nickel : CurrencyAbstract
  {
    public Nickel()
    {
      this.Name = "Nickel";
      this.Weight = 5;

    }
  }
}
