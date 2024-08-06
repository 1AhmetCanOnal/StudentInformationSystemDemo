using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework.Context
{
    public class StudentDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
            optionsBuilder.UseSqlServer("server=192.168.1.70;database=StudentDb;User Id=sa;Password=Server.112233++;Encrypt=False;");
          
        }

        
        public DbSet<Student> Students { get; set; }
      
    }
}
