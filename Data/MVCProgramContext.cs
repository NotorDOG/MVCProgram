using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCProgram.Models;

namespace MVCProgram.Data
{
    public class MVCProgramContext : DbContext
    {
        public MVCProgramContext (DbContextOptions<MVCProgramContext> options)
            : base(options)
        {
        }

        public DbSet<MVCProgram.Models.Movie> Movie { get; set; }
    }
}
