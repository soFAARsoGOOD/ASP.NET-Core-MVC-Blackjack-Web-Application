using BlackJack.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures; // Required for TempData access

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSingleton<ITempDataDictionaryFactory, TempDataDictionaryFactory>(); // Enables TempData in Tag Helpers

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IGame, Game>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
