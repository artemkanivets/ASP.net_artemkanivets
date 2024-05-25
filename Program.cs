using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using lab_1_asp_net.Models;
using lab_1_asp_net.Resources;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Localization.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;




var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllersWithViews()
    .AddDataAnnotationsLocalization();
builder.Services.AddLocalization(/*options => options.ResourcesPath = "Resources"*/);
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    List<CultureInfo> supportedCultures = new List<CultureInfo>()
    {
        new CultureInfo("en-us"),
        new CultureInfo("uk-ua")
    };
    options.DefaultRequestCulture = new RequestCulture("en-us");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;

    var requestProvider = new RouteDataRequestCultureProvider();
    options.RequestCultureProviders.Insert(0, requestProvider);
});

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

app.UseRequestLocalization(app.Services.GetService<IOptions<RequestLocalizationOptions>>().Value);

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute(
        name: "order",
        pattern: "Order/{action=Index}/{id?}",
        defaults: new { controller = "Order", action = "Index" });

});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute(
        name: "user",
        pattern: "User/{action=Index}/{id?}",
        defaults: new { controller = "User", action = "Index" });
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "movie",
        pattern: "Movie/{action=Privacy}/{id?}",
        defaults: new { controller = "Movie" });
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Privacy}/{id?}");
});

app.MapControllerRoute(
    name: "default",
    pattern: "{culture=en-US}/{controller=Home}/{action=Index}/{id?}");

app.Run();
