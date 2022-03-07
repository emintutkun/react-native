using AdvancedRepository.Models.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.Data
{
    public class SirketContext:DbContext
    {
        public SirketContext(DbContextOptions<SirketContext> options) : base(options)
        {
     
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Counties> Counties { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Units> Units { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FatDetail>()
                .HasKey(f => new {f.Id,f.ProductId });
        }
    
        public DbSet<FatDetail> FatDetails { get; set; }

        public DbSet<FatMaster> FatMasters { get; set; }

    }
}
