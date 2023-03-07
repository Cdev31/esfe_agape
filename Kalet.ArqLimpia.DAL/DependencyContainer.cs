using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Kalet.ArqLimpia.EN.Interfaces;


namespace Kalet.ArqLimpia.DAL
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddDALDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<KaletDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("conexion")));

            services.AddScoped<IUser, UserDAL>();
            services.AddScoped<IUnityOfWork, IUnityOfWork>();

            return services;
        }
    }
}
