using Microsoft.EntityFrameworkCore;
using WebAppTest.Models;

namespace WebAppTest.Data
{
    public class EmpDbContext : DbContext {
        public EmpDbContext(DbContextOptions options) : base(options) { }

        #region DbSet
        public DbSet<Employee> Employees { get; set; }
        #endregion
    }
}
