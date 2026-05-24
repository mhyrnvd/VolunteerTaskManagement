using FluentValidation;

namespace VolunteerTaskManagement.Application.CQRS.Auth
{
    public class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(x => x.UserName)
                .NotEmpty()
                .WithMessage("نام کاربری اجباری است!");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("پسوورد اجباری است!");
        }
    }
}
