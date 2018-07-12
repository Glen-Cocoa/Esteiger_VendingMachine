using Esteiger_VendingMachine.Resources.products;
using Esteiger_VendingMachine.Resources.money;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esteiger_VendingMachine
{
  class VendingMachine
  {
    private List<IProduct> VMInventory = new ProductCatalogue().PopulateCatalogue();

    public List<IProduct> ReturnInventory()
    {
      return this.VMInventory;
    }

    public List<IProduct> ReturnInventoryLessThanTwo()
    {
      var result = VMInventory.FindAll(x => x.GetCost() < 2);
      return result;
    }

    public void ListProducts()
    {
      foreach (var Entry in this.VMInventory)
      {
        Console.WriteLine(Entry.Name);
      }
    }

    public void ListPrices()
    {
      foreach (var Entry in this.VMInventory)
      {
        Console.WriteLine(Entry.GetCost());
      }
    }
  }
}
