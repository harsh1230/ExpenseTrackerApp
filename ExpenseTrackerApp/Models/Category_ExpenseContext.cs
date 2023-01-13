using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExpenseTrackerApp.Models
{
    public class Category_ExpenseContext : DbContext
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Expenses> Expenses { get; set; }
        public DbSet<ExpenseLimit> ExpenseLimits { get; set; }
    }
}