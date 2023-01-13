using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExpenseTrackerApp.Models
{
    [Table("Categories")]
    public class Categories
    {
        [Key]
        public int? CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public int CategoryExpenseLimit { get; set; }

        public List<Expenses> Expense_List { get; set; }
    }
}