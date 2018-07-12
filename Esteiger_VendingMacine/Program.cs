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
      var x = new ProductCatalogue();
      var y = x.PopulateCatalogue();

      Console.WriteLine(y[1].GetCost());
    }
  }
}
