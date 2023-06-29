using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Baithi_HAH.Models;

namespace ApplicationDb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Baithi_HAH.Models.HAHCau3> HAHCau3 { get; set; } = default!;
    }
}
