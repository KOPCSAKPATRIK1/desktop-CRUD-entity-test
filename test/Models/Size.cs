using System;
using System.Collections.Generic;

namespace test.Models;

public partial class Size
{
    public int Id { get; set; }

    public int Size1 { get; set; }

    public virtual ICollection<Stock> Stocks { get; } = new List<Stock>();

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
