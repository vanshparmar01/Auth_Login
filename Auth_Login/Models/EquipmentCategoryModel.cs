public class EquipmentCategoryModel
{
    public required List<Product> Products { get; set; }
}

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public decimal Price { get; set; }
    public decimal OldPrice { get; set; }
    public required string ImageUrl { get; set; }
    public float Rating { get; set; }
    public int ReviewsCount { get; set; }
}