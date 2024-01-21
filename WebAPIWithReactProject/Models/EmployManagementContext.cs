using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebAPIWithReactProject.Models;

public partial class EmployManagementContext : DbContext
{
    public EmployManagementContext()
    {
    }

    public EmployManagementContext(DbContextOptions<EmployManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-B0CB314;Database=EmployManagement;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Employeeid).HasName("PK__EMPLOYEE__8F06515B78105C4E");

            entity.ToTable("EMPLOYEE");

            entity.Property(e => e.Employeeid).HasColumnName("EMPLOYEEID");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.Department)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Gender)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("GENDER");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NAME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
