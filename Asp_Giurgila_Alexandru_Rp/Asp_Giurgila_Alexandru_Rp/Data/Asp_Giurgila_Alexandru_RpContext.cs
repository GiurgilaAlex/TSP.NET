using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Giurgila_Alexandru_Rp.Models;

namespace Asp_Giurgila_Alexandru_Rp.Data
{
    public class Asp_Giurgila_Alexandru_RpContext : DbContext
    {
        public Asp_Giurgila_Alexandru_RpContext (DbContextOptions<Asp_Giurgila_Alexandru_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Giurgila_Alexandru_Rp.Models.Movie> Movie { get; set; }
    }
}
