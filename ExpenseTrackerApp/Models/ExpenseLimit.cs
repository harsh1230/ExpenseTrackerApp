using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExpenseTrackerApp.Models
{
    [Table("ExpenseLimit")]
    public class ExpenseLimit
    {
        [Key]
        public int ExpenseLimitId { get; set; }
        [Required]
        public int TotalExpenseLimit { get; set; }
    }
}