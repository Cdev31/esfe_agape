using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kalet.ArqLimpia.EN.Interfaces;

namespace Kalet.ArqLimpia.DAL
{
    public class UnityOfWork
    {
        readonly KaletDbContext dbContext;
        public UnityOfWork(KaletDbContext pDbContext)
        {
            dbContext = pDbContext;
        }
        public Task<int> SaveChangesAsync()
        {
            return dbContext.SaveChangesAsync();
        }
    }
}
