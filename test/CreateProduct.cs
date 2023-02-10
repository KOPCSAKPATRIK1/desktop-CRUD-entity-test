using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test;

public class CreateProduct
{
	public CreateProduct(string conn, string name, string desc, string productImage)
	{
		using var productContext = new ProductContext(conn);
		productContext.Add(new Product
		{
			Name = name,
			Desc = desc,
			ProductImage = productImage,
		});
		productContext.SaveChanges();
	}
}
