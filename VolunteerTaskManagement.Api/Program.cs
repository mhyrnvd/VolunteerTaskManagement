using VolunteerTaskManagement.Gateway.Registration;

var builder = WebApplication.CreateBuilder(args);

builder.RegisterServices(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
