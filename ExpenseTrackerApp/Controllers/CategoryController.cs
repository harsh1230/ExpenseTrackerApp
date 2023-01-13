using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpenseTrackerApp.Models;
using System.Data.Entity;

namespace ExpenseTrackerApp.Controllers
{
    public class CategoryController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "CategoryId, CategoryName, CategoryExpenseLimit")] Categories c)
        {
            if (ModelState.IsValid)
            {
                Category_ExpenseContext cec = new Category_ExpenseContext();
                var category = cec.Categories.FirstOrDefault(ca => ca.CategoryName == c.CategoryName);
                if (category == null)
                {
                    cec.Categories.Add(c);
                    cec.SaveChanges();
                    TempData["AlertMessage"] = "Category has been successfully added!";

                    return RedirectToAction("Index_Category", "Home");
                }
                else
                {
                    TempData["ErrorMessage"] = "Category already exists!";

                    return RedirectToAction("Index_Category", "Home");
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Category_ExpenseContext cec = new Category_ExpenseContext();
            Categories category = cec.Categories.Single(c => c.CategoryId == id);

            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Categories c)
        {
            if (ModelState.IsValid)
            {
                Category_ExpenseContext cec = new Category_ExpenseContext();
                cec.Entry(c).State = EntityState.Modified;
                cec.SaveChanges();
                TempData["AlertMessage"] = "Category has been successfully edited!";

                return RedirectToAction("Index_Category", "Home");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Category_ExpenseContext cec = new Category_ExpenseContext();
            Categories category = cec.Categories.Single(c => c.CategoryId == id);
            cec.Categories.Remove(category);
            cec.SaveChanges();
            TempData["AlertMessage"] = "Category has been successfully deleted!";

            return RedirectToAction("Index_Category", "Home");
        }
    }
}