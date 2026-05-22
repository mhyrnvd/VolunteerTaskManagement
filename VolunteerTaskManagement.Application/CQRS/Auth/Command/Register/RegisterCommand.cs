using MediatR;
using Microsoft.AspNetCore.Identity;
using Base.Application.Contracts.DTOs.Common;
using VolunteerTaskManagement.Domain.Entities;
using VolunteerTaskManagement.Application.Contracts.Repositories;

namespace VolunteerTaskManagement.Application.CQRS.Auth
{
    public class RegisterCommand : IRequest<Result<bool>>
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string ConfirmedPassword { get; set; }
    }

    public class RegisterCommandHandler(IVolunteerTaskManagementUnitOfWork uow)
        : IRequestHandler<RegisterCommand, Result<bool>>
    {
        public async Task<Result<bool>> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var user = new User()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Role = "Volunteer",
                UserName = request.FirstName + ' ' + request.LastName
            };
            user.PasswordHash = new PasswordHasher<User>()
                .HashPassword(user, request.Password);

            await uow.Users.AddAsync(user);
            await uow.CommitAsync();

            return Result<bool>.Success(true);
        }
    }
}