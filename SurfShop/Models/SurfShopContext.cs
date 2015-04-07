using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SurfShop.Models
{
	public class SurfShopContext : DbContext
	{
		public SurfShopContext() : base("SurfShopContext")
		{
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Company> Companies { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<SubCategory> SubCategories { get; set; }

	}
}