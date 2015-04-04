﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurfShop.Models
{
	public class SubCategory
	{
		public int SubCategoryID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int CategoryID { get; set; }

		public virtual ICollection<Product> Products { get; set; }
	}
}