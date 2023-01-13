using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpenseTrackerApp.Models;

namespace ExpenseTrackerApp.Controllers
{
    public class ExpenseLimitController : Controller
    {
        [HttpGet]
        public ActionResult Expense_Limit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Expense_Limit(ExpenseLimit el)
        {
            if(ModelState.IsValid)
            {
                Category_ExpenseContext cec = new Category_ExpenseContext();
                cec.ExpenseLimits.Add(el);
                cec.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}