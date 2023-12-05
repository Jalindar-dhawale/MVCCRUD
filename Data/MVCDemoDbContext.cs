using Microsoft.EntityFrameworkCore;
using SoftmassAssignment.Models.Domain;

namespace SoftmassAssignment.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
