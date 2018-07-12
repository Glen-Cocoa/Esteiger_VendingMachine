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
    public List<IProduct> VMInventory = new ProductCatalogue().PopulateCatalogue();
    public List<IProduct> VMCart = new List<IProduct>();
    public List<Currency> VMBank = new List<Currency>();

    //public void CheckOut()
    //{
    //  if()
    //}
    public void AddToBank(Currency C)
    {
      VMBank.Add(C);
      Console.WriteLine($"You have added a {C.Name}. Your Current Balance is {GetBankBalance()}");
    }

    public float GetBankBalance()
    {
      int sum = 0;
      foreach (var entry in VMBank)
      {
        sum += entry.Weight;
      }
      float balance = (float)sum / 100;
      return balance;
    }

    public float GetCartTotal()
    {
      int sum = 0;
      foreach (var item in VMCart)
      {
        sum += item.Weight;
      }
      float total = (float)sum / 100;
      return total;
    }

    public void AddItemToCart(IProduct Item)
    {
      VMCart.Add(Item);
      Console.WriteLine($"You have successfully added {Item.Name} to your Cart. Its cost is ${Item.GetCost()}");
    }

    public void EmptyCart()
    {
      VMCart.RemoveAll(x => true);
      Console.WriteLine("Your cart has been emptied");
    }

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
