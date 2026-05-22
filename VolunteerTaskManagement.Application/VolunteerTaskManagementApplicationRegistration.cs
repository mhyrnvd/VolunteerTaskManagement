using Base.Application;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace VolunteerTaskManagement.Application
{
    public static class VolunteerTaskManagementApplicationRegistration
    {
        public static void RegisterVolunteerTaskManagementApplication(this WebApplicationBuilder builder, IConfiguration configuration)
        {
            var services = builder.Services;

            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddFluentValidation(Assembly.GetExecutingAssembly());

        }
    }
}