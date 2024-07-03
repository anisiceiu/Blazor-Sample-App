using UAM.Models;
using Microsoft.EntityFrameworkCore;
using Paccar.Parts.DATA.Models;

namespace UAM.DAL
{
    public class DataAppsContext : DbContext
    {
        public DataAppsContext()
        {
            

        }
        public DataAppsContext(DbContextOptions<DataAppsContext> options)
          : base(options)
        {
        }
        

        public DbSet<Hose21mFittingVolume> Hose21mFittingVolume { get; set; }   
        public DbSet<Application> Application { get; set; }
        public DbSet<Table> Table { get; set; }

    }
}
