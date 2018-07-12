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
      VendingMachine YourVendingMachine = new VendingMachine();

      OptionPrompt();

      void InvalidChoice()
      {
        Console.WriteLine("Please enter a valid Choice \r\n");
        OptionPrompt();
      }

      void OptionPrompt()
      {
        Console.WriteLine("Hello, Welcome to your VENDING MACHINE. Would you like to \r\n A) ADD MONEY, \r\n B) ADD PRODUCT, or \r\n C) CHECKOUT? \r\n To retrieve all products less than $2 enter option D");
        Console.WriteLine("Please enter your selection as A, B, C, or D");

        string reply = Console.ReadLine();
        if (reply != "A" && reply != "B" && reply != "C" && reply != "D")
        {
          InvalidChoice();
          return;
        }
        if (reply == "A")
        {
          MoneyPrompt();
        }
        if (reply == "B")
        {
          ProductPrompt();
        }
        if (reply == "C")
        {
          YourVendingMachine.CheckOut();
        }
        if (reply == "D")
        {
          List<IProduct> products = YourVendingMachine.ReturnInventoryLessThanTwo();
          for (int i = 0; i < products.Count; i++)
          {
            Console.WriteLine($"{products[i].Name} : {products[i].Value} cents");
            //YourVendingMachine.AddItemToCart(i+1);
            //YourVendingMachine.CheckOut();
          }
        }
      }

      void MoneyPrompt()
      {
        Console.WriteLine("Would you like to \r\n A) Insert a Dollar \r\n B) Insert a Quarter \r\n C) Insert a Dime \r\n D) Insert a Nickel");

        string MoneyReply = Console.ReadLine();
        if (MoneyReply != "A" && MoneyReply != "B" && MoneyReply != "C" && MoneyReply != "D")
        {
          InvalidChoice();
          OptionPrompt();
        }
        if (MoneyReply == "A")
        {
          YourVendingMachine.AddToBank(new Dollar());
          OptionPrompt();
        }
        if (MoneyReply == "B")
        {
          YourVendingMachine.AddToBank(new Quarter());
          OptionPrompt();
        }
        if (MoneyReply == "C")
        {
          YourVendingMachine.AddToBank(new Dime());
          OptionPrompt();
        }
        if (MoneyReply == "D")
        {
          YourVendingMachine.AddToBank(new Nickel());
          OptionPrompt();
        }
      }

      void ProductPrompt()
      {
        Console.WriteLine($"Please choose from the list of {YourVendingMachine.ReturnInventory().Count} available products by entering the corresponding number");
        YourVendingMachine.ListProducts();
        int ProductReply;
        try
        {
          ProductReply = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
          InvalidChoice();
          throw;
        }
        if (ProductReply > YourVendingMachine.NumberOfProducts())
        {
          InvalidChoice();
        }
        else
        {
          YourVendingMachine.AddItemToCart(ProductReply-1);
          OptionPrompt();
        }
      }

    }
  }
}
