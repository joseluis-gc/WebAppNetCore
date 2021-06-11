using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppNetCore.Models
{
	public class Product
	{
		[Key]
		public int Product_id { get; set; }



		[Required]
		public string Name { get; set; }
		
		

		public string Description { get; set; }


		[Range(1,int.MaxValue)]
		public double Price { get; set; }



		public string Image { get; set; }



		[Display(Name = "Category_Type")]
		public int Category_id { get; set; }
		[ForeignKey("Category_id")]
		public virtual Category Category { get; set; }
	}
}
