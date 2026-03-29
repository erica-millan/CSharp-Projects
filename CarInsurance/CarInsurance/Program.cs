using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;
using CarInsurance.Models;


var builder = WebApplication.CreateBuilder(args);

// Register services (features/tools) the app will use
builder.Services.AddControllersWithViews();

//tell asp.net how to coonnect to the db
builder.Services.AddDbContext<CarInsuranceContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CarInsurance")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
//redirect all http requests to https automaticaly
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//defines default route pattern
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
