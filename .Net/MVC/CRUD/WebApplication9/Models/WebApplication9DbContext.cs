using Microsoft.EntityFrameworkCore;

namespace WebApplication9.Models

{
    public class WebApplication9DbContext :DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public WebApplication9DbContext(DbContextOptions<WebApplication9DbContext> options) : base(options) { }
    }
}
