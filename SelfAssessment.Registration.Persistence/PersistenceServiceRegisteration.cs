using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SelfAssessment.Registration.Application.Contracts.Persistence;
using SelfAssessment.Registration.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment.Registration.Persistence
{
    public static class PersistenceServiceRegisteration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SelfAssessmentDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SelfAssessmentConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IPayerRepository, PayerRepository>();

            return services;
        }
    }
}
