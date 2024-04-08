﻿using System.ComponentModel.DataAnnotations;

public class ShoppingCartItem
{
    [Key]
    public int Id { get; set; }
    public required string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}