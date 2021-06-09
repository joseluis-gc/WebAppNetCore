using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppNetCore.Models
{
	public class Category
	{
		[Key]
		public int CategoryId{ get; set; }
		
		

		[Required]
		[DisplayName("Category Name")]
		public String CategoryName{ get; set; }
		
		

		[Required]
		[Range(1,int.MaxValue, ErrorMessage ="Value has to be bigger than 0.")]
		[DisplayName("Display Order")]
		public int DisplayOrder{ get; set; }

	}
}
