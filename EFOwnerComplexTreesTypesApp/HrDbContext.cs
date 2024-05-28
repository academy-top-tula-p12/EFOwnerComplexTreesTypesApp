using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFOwnerComplexTreesTypesApp;

public partial class HrDbContext : DbContext
{
    public HrDbContext()
    {
    }

    public HrDbContext(DbContextOptions<HrDbContext> options)
        : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }

    //public DbSet<Book> Books { get; set; }
    //public DbSet<Modul> Modules { get; set; }


    //public virtual DbSet<Capital> Capitals { get; set; }

    //public virtual DbSet<Company> Companies { get; set; }

    //public virtual DbSet<Country> Countries { get; set; }

    //public virtual DbSet<Employee> Employees { get; set; }

    //public virtual DbSet<EmployeeProject> EmployeeProjects { get; set; }

    //public virtual DbSet<Position> Positions { get; set; }

    //public virtual DbSet<Project> Projects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-ISC66B9\\MSSQLSERVER2022;Initial Catalog=hr_db;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Capital>(entity =>
        //{
        //    entity.ToTable("Capital");

        //    entity.HasIndex(e => e.CountryId, "IX_Capital_CountryId").IsUnique();

        //    entity.HasOne(d => d.Country).WithOne(p => p.Capital).HasForeignKey<Capital>(d => d.CountryId);
        //});

        //modelBuilder.Entity<Company>(entity =>
        //{
        //    entity.HasIndex(e => e.CountryId, "IX_Companies_CountryId");

        //    entity.HasOne(d => d.Country).WithMany(p => p.Companies).HasForeignKey(d => d.CountryId);
        //});

        //modelBuilder.Entity<Employee>(entity =>
        //{
        //    entity.HasIndex(e => e.CompanyId, "IX_Employees_CompanyId");

        //    entity.HasIndex(e => e.PositionId, "IX_Employees_PositionId");

        //    entity.HasOne(d => d.Company).WithMany(p => p.Employees).HasForeignKey(d => d.CompanyId);

        //    entity.HasOne(d => d.Position).WithMany(p => p.Employees).HasForeignKey(d => d.PositionId);
        //});

        //modelBuilder.Entity<EmployeeProject>(entity =>
        //{
        //    entity.HasKey(e => new { e.EmployeeId, e.ProjectId });

        //    entity.ToTable("EmployeeProject");

        //    entity.HasIndex(e => e.ProjectId, "IX_EmployeeProject_ProjectId");

        //    entity.Property(e => e.FinishDate).HasDefaultValueSql("(getdate())");

        //    entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeProjects).HasForeignKey(d => d.EmployeeId);

        //    entity.HasOne(d => d.Project).WithMany(p => p.EmployeeProjects).HasForeignKey(d => d.ProjectId);
        //});

        //modelBuilder.Entity<Project>(entity =>
        //{
        //    entity.ToTable("Project");
        //});

        //modelBuilder.Entity<Employee>().OwnsOne(e => e.EmployeeInfo);

        //modelBuilder.Entity<Book>(
        //    b =>
        //    {
        //        b.ComplexProperty(bk => bk.Teacher);
        //    });

        //modelBuilder.Entity<Modul>(
        //    b =>
        //    {
        //        b.ComplexProperty(md => md.Teacher);
        //    });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
