using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using BlazorApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Conexión-------------------------------------------------------
var ConStr = builder.Configuration.GetConnectionString("ConStr");

builder.Services.AddDbContext<Context>(options => options.UseSqlite(ConStr));
//--------------------------------------------------------------------------
//Inyectando la BLL OCUPATIONS
builder.Services.AddScoped<OcupationsBLL>();
//INYECTANDO BLL PERSON---------------------------------------------------------------------------
builder.Services.AddScoped<PersonBLL>();
//INYECTANDO BLL LOANS---------------------------------------------------------------------------
builder.Services.AddScoped<LoansBLL>();
//INYECTANDO BLL Payments---------------------------------------------------------------------------
builder.Services.AddScoped<Payments>();


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
