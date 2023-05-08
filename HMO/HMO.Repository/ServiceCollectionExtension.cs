using HMO.Repository.Interfaces;
using HMO.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Repository
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICityRepository, CityRepository>();

            services.AddScoped<IProducerRepository, ProducerRepository>();
            services.AddScoped<IVaccinationRepository, VaccinationRepository>();
            services.AddScoped<IPersonalDetailesRepository, PersonalDetailesRepository>();
            return services;
        }
    }
}
