using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CoreDepartmanPersonel.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NB43UN3; database=CoreDepartmanPersonel; integrated security=true; Encrypt=False;");
        }



        public DbSet<departmanlar> departmanlars { get; set; }
        public DbSet<personel> personels { get; set; }
    }
}
