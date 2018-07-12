using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esteiger_VendingMachine.Resources.money
{
  public abstract class Currency
  {
    public string Name;
    public int Value;

    //public float GetValue()
    //{
    //  float Value = (float)Weight / 100;
    //  return Value;
    //}
  }
}
