using Base.Infrastructure.Implementation;
using VolunteerTaskManagement.Application.Contracts.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace VolunteerTaskManagement.Infrastructure.Implementation.Repositories
{
    public class VolunteerTaskManagementUnitOfWork(IVolunteerTaskManagementContext context, IServiceProvider serviceProvider)
        : UnitOfWork<IVolunteerTaskManagementContext>(context), IVolunteerTaskManagementUnitOfWork
    {
        public IUserRepository Users => serviceProvider.GetService<IUserRepository>();
    }
}