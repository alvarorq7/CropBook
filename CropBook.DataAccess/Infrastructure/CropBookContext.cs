using CropBookModels.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CropBook.Models.Infrastructure
{
    public class CropBookContext:DbContext
    {
        public DbSet<Crop> Crop { get; set; }
        public DbSet<Farm> Farm { get; set; }
        public DbSet<GreenHouse> GreenHouse { get; set; }
        public DbSet<Plot> Plot { get; set; }
        public DbSet<Variety> Variety { get; set; }
        public DbSet<Vegetable> Vegetable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=CropBookDb; Trusted_Connection=True;");
    }


}
