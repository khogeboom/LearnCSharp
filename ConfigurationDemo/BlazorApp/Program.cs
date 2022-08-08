using BlazorApp.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

// HIERARCHY FOR DEFAULT CONFIGURATION
// Chained configuration - can pull from previous configurations and add it to the one we're building now (latest configuration overrides previous one if overlapping values)
// appsettings.json
// appsettings.<environment>.json --> overwrites appsettings.json
// App secrets (secrets.json) - only in development mode --> overwrites appsettings.<environment>.json
// Environment Variables --> overwrites app secrets
// Command Line arguments --> overwrites environment variables

// Azure Key Vault - safely stores encrypted values


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

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
