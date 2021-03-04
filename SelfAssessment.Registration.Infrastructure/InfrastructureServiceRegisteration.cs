using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SelfAssessment.Registration.Application.Contracts.Infrastructure;
using SelfAssessment.Registration.Application.Models;
using SelfAssessment.Registration.Infrastructure.Mail;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment.Registration.Infrastructure
{
    public static class InfrastructureServiceRegisteration
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailService, EmailService>();
           

            return services;
        }

    }
}
