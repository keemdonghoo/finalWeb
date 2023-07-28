using finalWeb.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace finalWeb.Data
{
    public class FinalDbContext : DbContext
    {
        public FinalDbContext()
        {

        }

        public FinalDbContext(DbContextOptions<FinalDbContext> options)
         : base(options)
        {
        }

        public virtual DbSet<Check> Checks { get; set; }

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Lot> Lots { get; set; }

        public virtual DbSet<LotHistory> LotHistorys { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Process> Processes { get; set; }
        public virtual DbSet<PUser> Pusers { get; set; }

        public virtual DbSet<Stock> Stocks { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer("Server=127.0.0.1; Database=FinalDB; uid=FinalUser; pwd=1234; Encrypt=false");
    }
}
