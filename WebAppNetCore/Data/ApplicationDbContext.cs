using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppNetCore.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
		{
				
		}

		public DbSet<Models.Category> Category { get; set; }
		public DbSet<Models.ApplicationType> ApplicationType { get; set; }
		public DbSet<Models.Product> Product { get; set; }

	}
}
