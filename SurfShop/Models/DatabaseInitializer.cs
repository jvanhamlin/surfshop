using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SurfShop.Models;

namespace SurfShop.Models
{
	public class DatabaseInitializer : System.Data.Entity.DropCreateDatabaseAlways<SurfShopContext>
	{
		protected override void Seed(SurfShopContext context)
		{
			var companies = new List<Company>
			{
				new Company{CompanyID = 1, Name = "Liquid Force", Description = "Lorem ipsum"},
				new Company{CompanyID = 2, Name = "Dakine", Description = "Lorem ipsum"}
			};
			companies.ForEach(c => context.Companies.Add(c));
			context.SaveChanges();

			var categories = new List<Category>
			{
				new Category{CategoryID = 1, Name = "Kiteboarding Kites", Description = "Lorem ipsum"},
				new Category{CategoryID = 2, Name = "Kiteboarding Harnesses", Description = "Lorem ipsum"}
			};
			categories.ForEach(c => context.Categories.Add(c));
			context.SaveChanges();

			var products = new List<Product>
			{
				new Product{ProductID = 1, Name = "NRG 2015", Description = "Big air kite.", CompanyID = 1, CategoryID = 1},
				new Product{ProductID = 2, Name = "Pyro", Description = "Top of the line harness", CompanyID = 2, CategoryID = 2}
			};
			products.ForEach(p => context.Products.Add(p));
			context.SaveChanges();
		}
	}
}