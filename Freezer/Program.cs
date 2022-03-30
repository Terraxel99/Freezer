using Freezer.Business.Definitions;
using Freezer.Business.Implementations;

using Freezer.Data.Definitions;
using Freezer.Data.Providers.Sql;
using Freezer.Data.Providers.Sql.Concretes;

using Microsoft.EntityFrameworkCore;

// ===============================================

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IFreezerRepository, FreezerRepository>();

builder.Services.AddScoped<IFreezerService, FreezerService>();

builder.Services.AddDbContext<FreezerDbContext>(opt => 
    opt.UseSqlServer("Server=localhost;Database=Freezer;Trusted_Connection=True;"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
