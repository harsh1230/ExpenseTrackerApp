using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpenseTrackerApp.Models;
using System.Data.Entity;

namespace ExpenseTrackerApp.Controllers
{
    public class ExpenseController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult Create(Expenses e)
        {
            if(ModelState.IsValid)
            {
                
                Category_ExpenseContext cec = new Category_ExpenseContext();
                cec.Expenses.Add(e);
                cec.SaveChanges();
                TempData["AlertMessage"] = "Expense has been successfully added!";

                return RedirectToAction("Index_Expense", "Home");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Category_ExpenseContext cec = new Category_ExpenseContext();
            Expenses expense = cec.Expenses.Single(e => e.ExpenseId == id);

            return View(expense);
        }

        [HttpPost]
        public ActionResult Edit(Expenses e)
        {
            if (ModelState.IsValid)
            {
                Category_ExpenseContext cec = new Category_ExpenseContext();
                cec.Entry(e).State = EntityState.Modified;
                cec.SaveChanges();
                TempData["AlertMessage"] = "Expense has been successfully edited!";

                return RedirectToAction("Index_Expense", "Home");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Category_ExpenseContext cec = new Category_ExpenseContext();
            Expenses expense = cec.Expenses.Single(e => e.ExpenseId == id);
            cec.Expenses.Remove(expense);
            cec.SaveChanges();
            TempData["AlertMessage"] = "Expense has been successfully deleted!";

            return RedirectToAction("Index_Expense", "Home");
        }
    }
}