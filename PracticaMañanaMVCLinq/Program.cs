using Microsoft.EntityFrameworkCore;
using PracticaMa�anaMVCLinq.Data;
using PracticaMa�anaMVCLinq.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string connectionString = builder.Configuration.GetConnectionString("hospitallocal");
builder.Services.AddDbContext<HospitalContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddTransient<RepositoryDepartamentos>();
builder.Services.AddTransient<RepositoryEmpleados>();

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
    pattern: "{controller=Departamentos}/{action=ListadoDepartamentos}/{id?}");

app.Run();
