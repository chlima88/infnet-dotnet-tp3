using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TpMVC.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<InfnetDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("TPContext") ?? throw new InvalidOperationException("Connection string 'TPContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Computadores}/{action=Index}/{id?}");

app.Run();
