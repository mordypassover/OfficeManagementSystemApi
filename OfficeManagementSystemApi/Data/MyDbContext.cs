using Microsoft.EntityFrameworkCore;
using OfficeManagementSystemApi.Models;
using System.Reflection.Metadata;


namespace OfficeManagementSystemApi.Data;

public class MyDbContext: DbContext
{

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Project> Projects { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>()
            .HasMany(e => e.Employees)
            .WithOne(e => e.Department)
            .HasForeignKey(e => e.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();

        modelBuilder.Entity<Department>()
        .HasMany(e => e.Projects)
        .WithOne(e => e.Department)
        .HasForeignKey(e => e.DepartmentId)
        .IsRequired();


    }

}
