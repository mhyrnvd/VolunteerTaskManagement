using Base.Api.Registration;
using VolunteerTaskManagement.Application;
using VolunteerTaskManagement.Infrastructure;

namespace VolunteerTaskManagement.Gateway.Registration
{
    public static class ServiceRegistration
    {
        public static void RegisterServices(this WebApplicationBuilder builder, IConfiguration configuration)
        {
            var services = builder.Services;

            builder.RegisterBaseApi(configuration);

            builder.RegisterVolunteerTaskManagementApplication(configuration);
            services.RegisterVolunteerTaskManagementInfra(configuration);
        }
    }
}