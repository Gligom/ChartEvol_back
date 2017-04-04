using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ChartEvol_back.Model
{
    


    public class DataContext : DbContext
    { 
        public virtual DbSet<Patient> Patient { get; set; }

            public DataContext(DbContextOptions<DataContext> options)
                : base(options)
            {
            }
    }

}


