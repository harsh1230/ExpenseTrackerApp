using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExpenseTrackerApp.Models
{
    [Table("Expenses")]
    public class Expenses
    {
        [Key]
        public int ExpenseId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public string CategoryName { get; set; }
    
        public int? CategoryId { get; set; }
    }
}