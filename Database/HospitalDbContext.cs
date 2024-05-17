using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Database
{
    public class HospitalDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Secretary> Secretarys { get; set; }
        public DbSet<Admin> Admins { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(u => u.Id).ValueGeneratedOnAdd(); // Set Id as auto-incrementing
                entity.HasKey(u => u.Id);
                entity.Property(u => u.name).IsRequired().HasMaxLength(50);
                entity.Property(u => u.surname).IsRequired().HasMaxLength(50);
                entity.Property(u => u.identification).IsRequired().HasMaxLength(50);
                entity.Property(u => u.GSM_No).IsRequired().HasMaxLength(50);
                entity.Property(u => u.password).IsRequired().HasMaxLength(50);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasOne(d => d.user)
                    .WithOne(u => u.Doctor)
                    .HasForeignKey<Doctor>(d => d.Id)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.Property(d => d.branch).IsRequired().HasMaxLength(50);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasOne(p => p.user)
                    .WithOne(u => u.Patient)
                    .HasForeignKey<Patient>(p => p.Id)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.Property(p => p.againPassword).IsRequired().HasMaxLength(50);
            });

            modelBuilder.Entity<Secretary>(entity =>
            {
                entity.HasOne(s => s.user)
                    .WithOne(u => u.Secretary)
                    .HasForeignKey<Secretary>(s => s.Id)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.Property(s => s.locationClinic).IsRequired().HasMaxLength(50);
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasOne(a => a.user)
                    .WithOne(u => u.Admin)
                    .HasForeignKey<Admin>(a => a.Id)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.Property(a => a.startDateOfEmployment).IsRequired();
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True;Trust Server Certificate=True");

        }
    }
}
