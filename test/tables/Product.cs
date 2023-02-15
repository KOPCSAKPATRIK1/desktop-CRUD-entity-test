﻿using System;
using System.Collections.Generic;

namespace test.tables;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Desc { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public int Price { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; } = new List<OrderItem>();

    public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; } = new List<ShoppingCartItem>();

    public virtual ICollection<Stock> Stocks { get; } = new List<Stock>();

    public virtual ICollection<Size> Sizes { get; } = new List<Size>();
}
