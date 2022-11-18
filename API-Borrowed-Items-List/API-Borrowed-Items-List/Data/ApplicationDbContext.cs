using API_Borrowed_Items_List.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Borrowed_Items_List.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}
