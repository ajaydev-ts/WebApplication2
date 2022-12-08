using Microsoft.EntityFrameworkCore;

namespace WebApplication2
{
    public class Empcontext:DbContext
    {
        public Empcontext(DbContextOptions options) : base(options) { }
        DbSet<Regmodel> Employees
        {
            get;
            set;
        }
    }
}
