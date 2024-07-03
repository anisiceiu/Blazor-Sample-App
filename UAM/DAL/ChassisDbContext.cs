using UAM.Models;
using Microsoft.EntityFrameworkCore;
using Paccar.Parts.DATA.Models;
using System.Data;

namespace UAM.DAL
{
    public class ChassisDbContext : DbContext
    {
        public ChassisDbContext()
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_Rev_per_Material>().HasNoKey();
        }
        public ChassisDbContext(DbContextOptions<ChassisDbContext> options)
          : base(options)
        {
        }
        public DbSet<tbl_Rev_per_Material> tbl_Rev_per_Material { get; set; }
    }
}
