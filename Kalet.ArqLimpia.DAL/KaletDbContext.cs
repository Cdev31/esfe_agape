using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kalet.ArqLimpia.EN;
using Microsoft.EntityFrameworkCore;

namespace Kalet.ArqLimpia.DAL
{
    public class KaletDbContext: DbContext
    {
        public KaletDbContext(DbContextOptions<KaletDbContext> options) : base(options) { }
        public DbSet<User> User { get; set; }
    }
}
