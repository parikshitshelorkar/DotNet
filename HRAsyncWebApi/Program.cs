using HRAsyncWebApi.Repositories;
using HRAsyncWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<EmployeeService>();


var app = builder.Build();

app.MapControllers();
app.Run();