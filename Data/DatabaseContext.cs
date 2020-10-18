using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace bono.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base (options)
        {
        }
        
        public DbSet<BONO.Models.bono> bono {get; set;}
    }
}
