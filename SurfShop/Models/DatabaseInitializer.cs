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
				new Company{CompanyID = 1, Name = "Liquid Force", Description = "Founded in 1995, Liquid Force quickly became the leader in wakeboard products and apparel. Soon after in 1999 Liquid Force entered into kiteboarding and became the benchmark in design and product progression."},
				new Company{CompanyID = 2, Name = "Dakine", Description = "Dakine is an American outdoor clothing company specializing in sportswear and sports equipment for alternative sports. Founded in Hawaii, the name comes from the Hawaiian Pidgin word &ldquo;da kine&rdquo; (derived from &ldquo;the kind&rdquo;). Now based in Oregon, the company also sponsors team riders from the lifestyle and sporting fields of skiing, biking, windsurfing, kiting, snowboarding, surfing, and skateboarding."},
				new Company{CompanyID = 3, Name = "Cabrinha", Description = "Since 2000, Cabrinha, a subsidiary of the Pryde Group, has climbed the ranks to take the position as the leading kitesurfing brand, selling in over 40 countries worldwide. Inspired and driven by Maui-based waterman, Pete Cabrinha, the company produces everything from kites to boards to accessories and sponsors the top athletes in the sport."},
				new Company{CompanyID = 4, Name = "Best Kiteboarding", Description = "Best Kiteboarding was launched in 2003, driven by our love for kiteboarding. Our desire is to create the best possible gear for every rider in the world. From day one we have remained 100 % committed to delivering absolute customer satisfaction."},
				new Company{CompanyID = 5, Name = "North Kiteboarding", Description = "As a brand we've always stayed true to our foundations; true to the sport. For more than ten years, we've maintained our belief that there is no substitute for high performance and premium quality. Our mission, is to enhance every individual’s experience."}
			};
			companies.ForEach(c => context.Companies.Add(c));
			context.SaveChanges();

			var categories = new List<Category>
			{
				new Category{CategoryID = 1, Name = "Kiteboarding", Description = "Lorem ipsum"},
				new Category{CategoryID = 2, Name = "Paddle Boards", Description = "Lorem ipsum"},
				new Category{CategoryID = 3, Name = "Surfing", Description = "Lorem ipsum"}
			};
			categories.ForEach(c => context.Categories.Add(c));
			context.SaveChanges();

			var subcategories = new List<SubCategory>
			{
				new SubCategory{SubCategoryID = 1, CategoryID = 1, Name = "Kites", Description = "The most important part of the Kiteboarding system. Absolutely necessary to harness the power of the wind."},
				new SubCategory{SubCategoryID = 2, CategoryID = 1, Name = "Harnesses", Description = "Important safety device to keep you and your kite connected at all times."},
				new SubCategory{SubCategoryID = 3, CategoryID = 1, Name = "Kiteboards", Description = "From a glassy surface to serious chop, the board keeps you gliding across the water."},
				new SubCategory{SubCategoryID = 4, CategoryID = 1, Name = "Trainer Kites", Description = "We all have to start somewhere. Learn the basics prior to your first lesson to make the most of learning how to fly."},
				new SubCategory{SubCategoryID = 5, CategoryID = 2, Name = "Stand Up Paddle Boards", Description = "Stand up paddle boards for any body of water."},
				new SubCategory{SubCategoryID = 6, CategoryID = 3, Name = "Short Boards", Description = "Line up and drop into the swells."},
				new SubCategory{SubCategoryID = 7, CategoryID = 3, Name = "Long Boards", Description = "Surf's up when the waves are down."}
			};
			subcategories.ForEach(s => context.SubCategories.Add(s));
			context.SaveChanges();

			var products = new List<Product>
			{
				new Product{ProductID = 1, Name = "NRG 2015", Description = "With it’s ultra-flat, shallow profile, this third-generation NRG is built on an efficient four-strut platform, which lets the kite fly more forward in the window, offering superior upwind performance, fast sweeping turns, and exhilarating lift for mega air and solid low-end pull.", CompanyID = 1, CategoryID = 1, SubCategoryID = 1},
				new Product{ProductID = 2, Name = "Pyro", Description = "Equipped with the fixed hook quick connect Leverlock Spreader Bar.", CompanyID = 2, CategoryID = 1, SubCategoryID = 2}
			};
			products.ForEach(p => context.Products.Add(p));
			context.SaveChanges();
		}
	}
}