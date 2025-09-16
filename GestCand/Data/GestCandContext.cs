using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestCand.Models;

namespace GestCand.Data
{
    public class GestCandContext : DbContext
    {
        public GestCandContext (DbContextOptions<GestCandContext> options)
            : base(options)
        {
        }

        public DbSet<GestCand.Models.Candidat> Candidat { get; set; } = default!;
    }
}
