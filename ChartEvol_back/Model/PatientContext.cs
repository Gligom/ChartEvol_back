using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ChartEvol_back.Model
{
    


    public class PatientContext : DbContext
    { 
        
            public PatientContext(DbContextOptions<PatientContext> options)
                : base(options)
            {
            }

        public DbSet<Patient> Pacienti { get; set; }
    }

}

