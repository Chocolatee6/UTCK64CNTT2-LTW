using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TvcDay09LabCF.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var tvcConnectString = builder.Configuration.GetConnectionString("TvcDay09LabCFConnection");
builder.Services.AddDbContext<TvcDay09LabCFContext>(tvcOptions => tvcOptions.UseSqlServer(tvcConnectString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
