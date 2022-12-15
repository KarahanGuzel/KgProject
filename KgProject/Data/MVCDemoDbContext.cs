using KgProject.Models;
using KgProject.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace KgProject.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
