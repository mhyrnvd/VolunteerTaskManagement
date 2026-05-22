using VolunteerTaskManagement.Domain.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VolunteerTaskManagement.Infrastructure.Persistence.Context;

namespace VolunteerTaskManagement.Infrastructure.Persistence.Seed
{
    public static class VolunteerTaskManagementSeed
    {
        public static void SeedDatabase(IApplicationBuilder builder)
        {
            using var scope = builder.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();

            var applicationContext = scope.ServiceProvider.GetRequiredService<VolunteerTaskManagementContext>();
            applicationContext.Database.Migrate();

            if (!applicationContext.Set<User>().Any())
            {
                applicationContext.Set<User>().Add(new User
                {
                    FirstName = "یاسمن",
                    LastName = "حاجی",
                    UserName = "یاسمن حاجی",
                    Email = "VolunteerTaskManagement@gmail.com",
                    PasswordHash = "AQAAAAIAAYagAAAAEH73e3F38FPbP+qDJRo33JIHDw0cFo+EEHDRC+FRS2MTvE9+F1KJMATxPTmKTHEuqw==",
                    Role = "Admin",
                    CreateDate = DateTime.Now
                });
                applicationContext.SaveChanges();
            }
        }
    }
}