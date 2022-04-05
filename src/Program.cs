using FluentValidation.AspNetCore;
using MediatR;
using System.Reflection;
using WebApplication2.Controllers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddFluentValidation(conf =>
{
    conf.RegisterValidatorsFromAssemblyContaining<Program>();
});

builder.Services.AddTransient<IDbContext, DbContext>();
builder.Services.AddTransient<IReportService, ReportService>();
builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

var app = builder.Build();
app.UseMiddleware<CustomExceptionHandlerMiddleware>();
app.UseRouting();
app.UseEndpoints(e => e.MapControllers());
app.Run();
