using Base.Api.Registration;
using VolunteerTaskManagement.Gateway.Registration;
using VolunteerTaskManagement.Infrastructure.Persistence.Seed;

var builder = WebApplication.CreateBuilder(args);

builder.RegisterServices(builder.Configuration);

var app = builder.Build();

VolunteerTaskManagementSeed.SeedDatabase(app);
app.UseCustomMiddlewares(builder);

app.Run();
