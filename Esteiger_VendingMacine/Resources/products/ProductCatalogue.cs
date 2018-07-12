﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esteiger_VendingMachine.Resources.products
{
  class ProductCatalogue
  {
    public Dictionary<string, int> productInventory = new Dictionary<string, int>()
    {
      {"Chips", 100},
      {"Soda", 100},
      {"Chocolate", 75},
      {"Candy", 150},
      {"Salsa", 300}
    };

    public List<IProduct> PopulateCatalogue()
    {
      List<IProduct> Catalogue = new List<IProduct>();

      foreach (KeyValuePair<string, int> pair in productInventory)
      {
        string name = pair.Key;
        int weight = pair.Value;

        Catalogue.Add(new Product(name, weight));
        //Console.WriteLine(name);
        //Console.WriteLine(weight);
      }

      return Catalogue;
    }
  }
}