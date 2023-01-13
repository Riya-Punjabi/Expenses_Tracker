using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Expense_Tracker_1.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName = "NVARCHAR(50)")]
        public string? Name { get; set; }

        public decimal limit { get; set; }

        [NotMapped]
        public List<Expense> Expenses { get; set; }
    }
}
