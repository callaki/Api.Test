using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Test
{
    public class dbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=MAREBPC54\\SQLEXPRESS;initial catalog=TEST;user id=testuser;password=123456;MultipleActiveResultSets=True;App=EntityFramework");
        }

        public virtual DbSet<OGRENCILER> OGRENCILER { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
