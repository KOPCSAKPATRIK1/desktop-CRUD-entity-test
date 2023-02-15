using System;
using System.Collections.Generic;

namespace test.tables;

public partial class Address
{
    public int Id { get; set; }

    public string StreetAddress { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public int PostalCode { get; set; }

    public int? UserId { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual User? User { get; set; }
}
