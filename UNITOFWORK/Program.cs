using Microsoft.EntityFrameworkCore;
using UNITOFWORK.Models;
using UNITOFWORK.Repository;
using UNITOFWORK.Service;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectDb")));
builder.Services.AddScoped<IProductRepository, ProductServiceImp>();
builder.Services.AddScoped<IOrderRepository, OrderServiceImp>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWorkImp>();
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
