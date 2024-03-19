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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=BILAL\\SQLEXPRESS;Initial Catalog=HospitalManagementSystemDatabase;Integrated Security=True;");
        }
    }
}
