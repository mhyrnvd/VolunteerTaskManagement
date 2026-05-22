using Base.Application.Contracts;
using Base.Infrastructure.Persistence.Context;
using VolunteerTaskManagement.Application.Contracts.Repositories;
using VolunteerTaskManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace VolunteerTaskManagement.Infrastructure.Persistence.Context
{
    public class VolunteerTaskManagementContext(DbContextOptions<VolunteerTaskManagementContext> options, IJwtManager jwtManger) 
        : BaseContext(options, typeof(User).Assembly, typeof(VolunteerTaskManagementContext).Assembly, jwtManger)
        , IVolunteerTaskManagementContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.SeedAdmin();
        }
    }
}