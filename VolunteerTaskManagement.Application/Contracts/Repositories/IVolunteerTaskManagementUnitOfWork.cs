using Base.Application.Contracts;

namespace VolunteerTaskManagement.Application.Contracts.Repositories
{
    public interface IVolunteerTaskManagementUnitOfWork : IUnitOfWork<IVolunteerTaskManagementContext>, IDisposable
    {
        IUserRepository Users { get; }
    }
}