namespace Sales{
  public class Product{
    public decimal PromocionalPrice {get; set;}
    public decimal Price {get; set;}
  }
}
namespace Inventory{
  public class Product{
    public int  Quantity {get; set;}
    public string Sku {get; set;} = string.Empty;
  } 
}