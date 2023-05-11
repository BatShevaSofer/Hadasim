using HMO.Repository;
using HMO.Services.Interfaces;
using HMO.Services.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Services
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
           
            services.AddScoped<IProducerService, ProducerService>();

            services.AddScoped<IPersonalDetailesService, PersonalDetailesService>();
            services.AddScoped<IVaccinationService, VaccinationService>();

            services.AddAutoMapper(typeof(MappingProfile));


            return services;
        }
    }
}
