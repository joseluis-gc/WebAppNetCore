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



		//GET EDIT
		public IActionResult Edit(int? id)
		{
			if(id == null || id == 0)
			{
				return NotFound();
			}

			var obj = _db.Category.Find(id);
			
			if(obj == null)
			{
				return NotFound();
			}

			return View(obj);
		}






		//POST Edit
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(Models.Category obj)
		{

			if (ModelState.IsValid)
			{
				_db.Category.Update(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(obj);


		}









		//GET DELETE
		public IActionResult Delete(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}

			var obj = _db.Category.Find(id);

			if (obj == null)
			{
				return NotFound();
			}

			return View(obj);
		}






		//POST DELETE
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult DeletePost(int? id)
		{

			if (id == null || id == 0)
			{
				return NotFound();
			}

			var obj = _db.Category.Find(id);

			if (obj == null)
			{
				return NotFound();
			}


			_db.Category.Remove(obj);
			_db.SaveChanges();
			return RedirectToAction("Index");

		}









	}
}




