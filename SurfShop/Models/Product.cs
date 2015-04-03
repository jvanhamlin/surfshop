using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurfShop.Models
{
	public class Product
	{
		public int ProductID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int CompanyID { get; set; }
		public int CategoryID { get; set; }

		public virtual Company Company { get; set; }
		public virtual Category Category { get; set; }
	}
}