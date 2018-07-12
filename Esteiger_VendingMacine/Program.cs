using Esteiger_VendingMachine.Resources.money;
using Esteiger_VendingMachine.Resources.products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esteiger_VendingMachine
{
  class Program
  {
    static void Main(string[] args)
    {
      var x = new VendingMachine();
      var y = x.VMInventory[0];
      x.AddItemToCart(y);
      x.AddItemToCart(y);
      x.AddItemToCart(y);
      x.AddToBank(new Dollar());
      x.AddToBank(new Dollar());
      x.AddToBank(new Dollar());

      x.GetBalance();
    }
  }
}
