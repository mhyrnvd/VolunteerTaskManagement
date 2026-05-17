using Base.Api.Registration;

namespace VolunteerTaskManagement.Gateway.Registration
{
    public static class ServiceRegistration
    {
        public static void RegisterServices(this WebApplicationBuilder builder, IConfiguration configuration)
        {
            var services = builder.Services;

            builder.RegisterBaseApi(configuration);

            //builder.RegisterEduGuideApplication(configuration);
            //services.RegisterEduGuideInfra(configuration);
        }
    }
}