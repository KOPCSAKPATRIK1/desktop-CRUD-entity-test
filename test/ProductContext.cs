using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test;

internal class ProductContext : DbContext
{
	private readonly string _connectionString;

	public ProductContext(string connectionString)
	{
		_connectionString = connectionString;
	}

	public DbSet<Product> Product { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseMySQL(_connectionString);
	}
}
