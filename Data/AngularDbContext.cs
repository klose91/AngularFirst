using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularFirst.Data
{
    public class AngularDbContext : DbContext
    {
        public AngularDbContext(DbContextOptions opts)
            : base(opts) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
