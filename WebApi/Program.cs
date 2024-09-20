using Application.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using Persistance.Contexts;
using Persistance.Repositories;
using WebApi.BackgroundServices;

var builder = WebApplication.CreateBuilder(args);







builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Database
var conn = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(conn);
},contextLifetime: ServiceLifetime.Singleton
);


// Repository Registiration
builder.Services.AddScoped<IVacancyRepository, VacancyRepository>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();


// Background services
builder.Services.AddHostedService<UpdateNotifier>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
