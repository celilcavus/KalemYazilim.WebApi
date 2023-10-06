using FluentValidation;
using FluentValidation.AspNetCore;
using KalemYazilim.WebAPI.DataAccessLayer;
using KalemYazilim.WebAPI.Model;
using KalemYazilim.WebAPI.Repository;
using KalemYazilim.WebAPI.Validatiors;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers()
    .AddFluentValidation(x =>
    {
        x.ImplicitlyValidateChildProperties = true;
    });
builder.Services.AddTransient<IValidator<Musteri>,MusteriValidatior>();

builder.Services.AddDbContext<KalemDb>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("connectionmssql"));
});

builder.Services.AddScoped<MalzemeRepository, MalzemeRepository>();
builder.Services.AddScoped<MusteriRepository, MusteriRepository>();
builder.Services.AddScoped<SatisFaturasiSatirlariRepository,SatisFaturasiSatirlariRepository>();
builder.Services.AddScoped<SatisFaturasi, SatisFaturasi>();
//builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
