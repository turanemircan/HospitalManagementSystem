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
        //public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Secretary> Secretaries { get; set; }
        public DbSet<Admin> Admins { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True;Trust Server Certificate=True");

        }
        public Patient PatientIDValidation(string ID)
        {
            return Patients.SingleOrDefault(p => p.identification == ID);
        }
        public Doctor DoctorIDValidation(string ID)
        {
            return Doctors.SingleOrDefault(p => p.identification == ID);
        }
        public Secretary SecretaryIDValidation(string ID)
        {
            return Secretaries.SingleOrDefault(p => p.identification == ID);
        }
        public Admin AdminIDValidation(string ID)
        {
            return Admins.SingleOrDefault(p => p.identification == ID);
        }
    }
}
