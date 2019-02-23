using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieconsoleApp.NewDb
{
    public class MovieconsoleContext : DbContext
    {
        public DbSet<Movieconsoletbl> Movieconsoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.MovieconsoleApp.NewDb;Trusted_Connection=True;");
        }
    }

    public class Movieconsoletbl
    {
        [Key]
        public int MovieconsoleId { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string category_name { get; set; }
     

    }


}