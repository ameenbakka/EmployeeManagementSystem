using System.Collections.Generic;
using EmployeeManagementSystem1.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem1.Data
{
    public class ApplicationDbContext : DbContext
    {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {
            }

            public DbSet<Employee> Employees { get; set; }

        
    }
}
