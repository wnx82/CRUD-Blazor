using CRUD.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Blazored.Toast;
using Blazorise;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Blazor;
using CRUD;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddHttpClient();
builder.Services.AddSingleton<StateContainer>();



//Ajout du service Toast
builder.Services.AddBlazoredToast();
builder.Services.AddBlazorise();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddBlazorise(options => { options.Immediate = true; });


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
app.MapControllers();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.MapRazorPages();
app.Run();
