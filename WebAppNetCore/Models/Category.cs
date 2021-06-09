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
		
		
		[DisplayName("Category Name")]
		public String CategoryName{ get; set; }
		
		
		[DisplayName("Display Order")]
		public int DisplayOrder{ get; set; }

	}
}
