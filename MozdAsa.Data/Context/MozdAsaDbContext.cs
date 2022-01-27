using Microsoft.EntityFrameworkCore;
using MozdAsa.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MozdAsa.Data.Context
{
    public class MozdAsaDbContext: DbContext
    {
        public MozdAsaDbContext(DbContextOptions<MozdAsaDbContext> options):base(options)
        {

        }
        public DbSet<Company> Companies { get; set; }
    }
}
