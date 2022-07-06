using Microsoft.EntityFrameworkCore;
using Project_19101001_002.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<NailedContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("Home/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(name: "default",
    pattern: "{Controller=Home}/{action=Index}/{id?}");

app.Run();
