using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpenseTrackerApp.Models;
using System.Dynamic;

namespace ExpenseTrackerApp.Controllers
{
    public class HomeController : Controller
    {
        public List<Categories> getCategories()
        {
            Category_ExpenseContext cec = new Category_ExpenseContext();
            List<Categories> lcategory = cec.Categories.ToList();

            return lcategory;
        }

        public List<Expenses> getExpenses()
        {
            Category_ExpenseContext cec = new Category_ExpenseContext();
            List<Expenses> lexpense = cec.Expenses.ToList();

            return lexpense;
        }

        public List<ExpenseLimit> getExpenseLimit()
        {
            Category_ExpenseContext cec = new Category_ExpenseContext();
            List<ExpenseLimit> lexpenselimit = cec.ExpenseLimits.ToList();

            return lexpenselimit;
        }

        public ActionResult Index()
        {
            dynamic dy = new ExpandoObject();
            dy.categorylist = getCategories();
            dy.expenselist = getExpenses();
            dy.expenselimit = getExpenseLimit();

            return View(dy);
        }

        public ActionResult Index_Category()
        {
            Category_ExpenseContext cec = new Category_ExpenseContext();
            List<Categories> categories = cec.Categories.ToList();

            return View(categories);
        }

        public ActionResult Index_Expense()
        {
            Category_ExpenseContext cec = new Category_ExpenseContext();
            List<Expenses> expenses = cec.Expenses.ToList();

            return View(expenses);
        }

        public ActionResult Expense_List(int id)
        {
            Category_ExpenseContext cec = new Category_ExpenseContext();
            List<Expenses> expenses = cec.Expenses.Where(e => e.CategoryId == id).ToList();

            return View(expenses);
        }
    }
}