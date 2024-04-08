using System.ComponentModel.DataAnnotations;

public class ShoppingCartViewModel
{
    [Key]
    public int Id { get; set; }
    public List<ShoppingCartItem> Items { get; set; }
    public decimal Subtotal { get; set; }
    public decimal Shipping { get; set; }
    public decimal Tax { get; set; }
    public decimal OrderTotal { get; set; }
}