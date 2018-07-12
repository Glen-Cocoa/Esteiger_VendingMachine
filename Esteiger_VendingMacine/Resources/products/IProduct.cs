namespace Esteiger_VendingMachine.Resources.products
{
  public interface IProduct
  {
    string Name { get;}
    int Weight { get;}
    float GetCost();
  }
}