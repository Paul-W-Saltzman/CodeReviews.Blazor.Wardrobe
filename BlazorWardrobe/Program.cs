using BlazorWardrobe.Application.Interfaces;
using BlazorWardrobe.Components;
using BlazorWardrobe.Infrastructure.Context;
using BlazorWardrobe.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContextFactory<WardrobeDbContext>(options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("WardrobeConnection")
        );

} );

builder.Services.AddScoped<IGarmentRepository, GarmentRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
