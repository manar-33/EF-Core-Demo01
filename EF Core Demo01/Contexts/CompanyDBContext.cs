using EF_Core_Demo01.Confgurations;
using EF_Core_Demo01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Demo01.Contexts
{
    internal class CompanyDBContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigrations());
            //modelBuilder.Entity<Employee>().HasKey(E=>E.EmpId);
            //modelBuilder.Entity<Employee>().Property(E => E.EmpId).UseIdentityColumn(1,1);
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = CompanyDB; Trusted_Connection = True;Encrypt=True;TrustServerCertificate=True");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
