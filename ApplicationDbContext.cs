using Expense_Tracker_1.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker_1
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Expense> Expense { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
