using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esteiger_VendingMachine.Resources.money
{
  public abstract class CurrencyAbstract
  {
    public string Name;
    public int Weight;

    public virtual float GetValue()
    {
      float Value = this.Weight / 100;
      return Value;
    }
  }
}
