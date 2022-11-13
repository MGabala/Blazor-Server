using BlazorServer;
using BlazorServer.Data;
using BlazorServer.Repositories;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<MainDatabase>(db_config => db_config.UseSqlite(builder.Configuration["ConnectionStrings:DB"]));
builder.Services.AddDbContextFactory<MainDatabase>(db_config => db_config.UseSqlite(builder.Configuration["ConnectionStrings:DB"]));


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<ApplicationState>();
builder.Services.AddScoped<IItemRepository,ItemRepository>();
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
