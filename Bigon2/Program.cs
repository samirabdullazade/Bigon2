using Bigon2.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var cString = builder.Configuration.GetConnectionString("cString");
builder.Services.AddDbContext<DataContext>(cfg =>
{
    cfg.UseSqlServer(cString);
});

var app = builder.Build();


app.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");

app.UseStaticFiles();

app.Run();
