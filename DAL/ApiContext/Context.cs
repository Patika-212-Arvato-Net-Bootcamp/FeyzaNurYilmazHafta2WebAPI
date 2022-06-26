using FeyzaNurYilmazHafta2WebAPI.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace FeyzaNurYilmazHafta2WebAPI.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=FEYZA-NB\\SQLEXPRESS01;database=CoreProjeFeyzaH2;integrated security=true");
        }

        public DbSet<Bootcamp> Bootcamps { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Student_Bootcamp> Student_Bootcamps { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Teacher_Bootcamp> Teacher_Bootcamps { get; set; }
    }
}
