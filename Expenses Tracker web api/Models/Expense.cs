using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Expense_Tracker_1.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Title { get; set; }

        public decimal Amount { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Description { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
