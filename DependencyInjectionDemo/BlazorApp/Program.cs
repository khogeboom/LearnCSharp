using BlazorApp.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddTransient<WeatherForecastService>();
builder.Services.AddTransient<IDataAccess, DummyDataAccess>(); // get instance of DummyDataAccess
// "AddSingleton" = create one instance for the entire life of the application and everyone will use that same version (can share data between user calls)
// "AddScoped" = like Singleton but only per user/session -- create instance of class and gives you that instance everytime in that session (new session = new instance)
// "AddTransient" = everytime you class this you get a new instance

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
