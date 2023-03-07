using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kalet.ArqLimpia.DAL;
using Kalet.ArqLimpia.BL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Kalet.ArqLimpi.BL;

namespace Kalet.ArqLimpia.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddESFEDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDALDependecies(configuration);
            services.AddBLDependecies();
            return services;
        }
    }
}
