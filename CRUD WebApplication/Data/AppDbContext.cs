using CRUD_WebApplication.Models;
using Microsoft.EntityFrameworkCore;


namespace CRUD_WebApplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
