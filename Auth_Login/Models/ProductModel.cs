using System.ComponentModel.DataAnnotations;

public class ProductModel
{
    [Key]
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string ImageUrl { get; set; }
    public decimal Price { get; set; }
    public decimal OldPrice { get; set; }
    public float Rating { get; set; }
    public int ReviewsCount { get; set; }
    public int SoldCount { get; set; }
    public required string Warranty { get; set; }
    public required string Protection { get; set; }
    public required string Customization { get; set; }
    public required string Design { get; set; }
    public required string Material { get; set; }
    public required string Type { get; set; }
    public required string PriceNegotiable { get; set; }
    //public required List<TradePriceModel> TradePrices { get; set; }
}

//public class TradePriceModel
//{
//    [Key]
//    public int Id { get; set; }
//    public int QuantityFrom { get; set; }
//    public int QuantityTo { get; set; }
//    public decimal Price { get; set; }
//}