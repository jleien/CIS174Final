using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using CIS174Final.Areas.Assignment.Models;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using CIS174Final.Areas.AssignmentModule7.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddMemoryCache();
builder.Services.AddSession();

// Add services to the container.
builder.Services.AddControllersWithViews().AddNewtonsoftJson();
builder.Services.AddDbContext<StudentContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("StudentContext")));
builder.Services.AddDbContext<CountryContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("CountryContext")));
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
app.UseSession();
app.UseAuthorization();

app.UseEndpoints(endpoints => // map the endpoints 
{
    endpoints.MapAreaControllerRoute(
        name: "AdminArea",
        areaName: "Administration",
        pattern: "Administration/{controller=AdminController}/{action=AdminIndex}/{id?}");

    endpoints.MapAreaControllerRoute(
       name: "AppArea",
       areaName: "Application",
       pattern: "Application/{controller=AppController}/{action=Index}/{id?}");

    endpoints.MapAreaControllerRoute(
        name: "AssignmentArea",
        areaName: "Assignment",
        pattern: "Assignment/{controller=AssignmentController}/{action=AssignmentIndex}/{id?}");

    endpoints.MapAreaControllerRoute(
        name: "AssignmentModule7Area",
        areaName: "AssignmentModule7",
        pattern: "{controller=CountryController}/{action=CountryIndex}/game/{activeGame?}/cat/{activeCat?}");

    endpoints.MapControllerRoute(
        name: "CharacterCreator",
        pattern: "{controller}/{action}/{cat}/Character{num}");
    

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

});

app.Run();
