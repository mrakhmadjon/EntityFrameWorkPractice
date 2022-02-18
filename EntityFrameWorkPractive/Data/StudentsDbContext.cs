using EntityFrameWorkPractive.Models;
using EntityFrameWorkPractive.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkPractive.Data
{
    
    internal class StudentsDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Constants.StringConnection);
        }

       public DbSet<Student> Students { get; set; }
        
        

    }
}
