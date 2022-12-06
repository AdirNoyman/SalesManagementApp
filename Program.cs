using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SalesManagementApp.Data;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddSyncfusionBlazor();

var app = builder.Build();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHNqVVhlVVpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF9iS35Wd0BjXn5feHdXQA==;Mgo+DSMBPh8sVXJ0S0V+XE9Bf1RDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS3xSdEVmWHped3VUTmRaVw==;Mgo+DSMBMAY9C3t2VVhjQlFac1ZJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxRd0djXH5bcHNUR2hZWEI=;Nzc0MTk3QDMyMzAyZTMzMmUzMEl5MkROSC93Ykc5VUkyaDRlVDNPUTF2VjVMVzZxaGVOS0NTamo0MzZlVFk9");
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

