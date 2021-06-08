﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppNetCore.Models
{
	public class Category
	{
		[Key]
		public int CategoryId{ get; set; }
		public String CategoryName{ get; set; }
		public int DisplayOrder{ get; set; }

	}
}
