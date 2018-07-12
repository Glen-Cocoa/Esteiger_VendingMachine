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
    private List<IProduct> VMCart = new List<IProduct>();
    private List<Currency> VMBank = new List<Currency>();

    public void CheckOut()
    {
      if (GetBankBalance() < GetCartTotal())
      {
        Console.WriteLine("Sorry, your balance is too low");
        return;
      }
      else if (GetBankBalance() == GetCartTotal())
      {
        Console.WriteLine("Your Balance is juuuuust right!");
        EmptyCart();
        EmptyBank();
        return;
      }
      else if (GetBankBalance() > GetCartTotal())
      {
        Console.WriteLine("Your balance is higher than the total! You have some change.");
        GetChange();
        EmptyCart();
        EmptyBank();
        return;
      }
      return;
    }

    public void GetChange()
    {
      int change = GetBankBalance() - GetCartTotal();
      Console.WriteLine($"You have {change} cents left over. Please collect your change.");
    }

    public void AddToBank(Currency C)
    {
      VMBank.Add(C);
      Console.WriteLine($"You have added a {C.Name}. Your Current Balance is {GetBankBalance()} cents");
      return;
    }

    public int GetBankBalance()
    {
      int sum = 0;
      foreach (Currency entry in VMBank)
      {
        sum += entry.Value;
      }
      //float balance = (float)sum / 100;
      return sum;
    }

    public int GetCartTotal()
    {
      int sum = 0;
      foreach (IProduct item in VMCart)
      {
        sum += item.Value;
      }
      //float total = (float)sum / 100;
      return sum;
    }

    public void AddItemToCart(int index)
    {
      VMCart.Add(VMInventory[index]);
      Console.WriteLine($"You have successfully added {VMInventory[index].Name} to your Cart. Its cost is {VMInventory[index].Value} cents");
    }

    public void EmptyCart()
    {
      VMCart.RemoveAll(x => true);
      Console.WriteLine("Your cart has been emptied");
    }
    public void EmptyBank()
    {
      VMBank.RemoveAll(x => true);
      Console.WriteLine("Your Bank has been emptied");
    }

    public List<IProduct> ReturnInventory()
    {
      return this.VMInventory;
    }

    public List<IProduct> ReturnInventoryLessThanTwo()
    {
      List<IProduct> result = VMInventory.FindAll(x => x.Value < 2);
      return result;
    }
    public int NumberOfProducts()
    {
      return VMInventory.Count;
    }

    public void ListProducts()
    {
      int count = 1;
      foreach (IProduct Entry in this.VMInventory)
      {
        Console.WriteLine($"\r\n {count})" + Entry.Name);
        count++;
      }
    }

    //public void ListPrices()
    //{
    //  foreach (var Entry in this.VMInventory)
    //  {
    //    Console.WriteLine(Entry.GetCost());
    //  }
    //}
  }
}
