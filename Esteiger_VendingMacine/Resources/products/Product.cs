using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esteiger_VendingMachine.Resources.products
{
  public class Product : IProduct
  {
    public string Name { get; }
    public int Weight { get;}
    public float GetCost()
    {
      float Value = (float)Weight / 100;
      return Value;
    }

    public Product(string name, int weight)
    {
      this.Name = name;
      this.Weight = weight;

    }
  }
}
