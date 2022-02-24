using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Comp2139_Assignment1.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Comp2139_Assignment1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Comp2139_Assignment1Context")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRouting(options =>
    {
        options.AppendTrailingSlash = true;
        options.LowercaseUrls = true;
    }

);

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
