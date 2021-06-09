using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppNetCore.Data;

namespace WebAppNetCore.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ApplicationDbContext _db;

		public CategoryController(ApplicationDbContext db)
		{
			_db = db;

		}

		public IActionResult Index()
		{
			IEnumerable<Models.Category> objList = _db.Category;
			return View(objList);
		}

		//GET CREATE
		public IActionResult Create()
		{
			return View();
		}


		//POST CREATE
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Models.Category obj)
		{

			if (ModelState.IsValid) 
			{
				_db.Category.Add(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(obj);

			
		}


	}
}
