using Microsoft.EntityFrameworkCore;
using RAMPControl.API.Models;

namespace RAMPControl.API.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){}
         public DbSet <DailyWorkComment> DailyComment { get; set; }
         public DbSet <User> Users { get; set; }
        
    }
}