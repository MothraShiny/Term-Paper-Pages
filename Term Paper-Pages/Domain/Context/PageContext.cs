using Microsoft.EntityFrameworkCore;

namespace Term_Paper_Pages.Domain
{
    public class PageContext : DbContext
    {
        //Содержит информацию о записях в БД
        public DbSet<Page> Pages { get; set; }

        public PageContext(string connectionString) : base(new DbContextOptionsBuilder().UseSqlServer(connectionString).Options)
        {   
        }
    }
}
