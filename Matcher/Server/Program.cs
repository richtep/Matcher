using EntitySystem.Server.Fluent;
using FluentNHibernate.Cfg.Db;
using Matcher.Server.Services;
using Matcher.Shared.Domain;
using NHibernate.Dialect;

var builder = WebApplication.CreateBuilder(args);

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

//production 
builder.Services.AddEntitySystemServerFluent<ItemService, Item>(PostgreSQLConfiguration.Standard.ConnectionString("server=Database;Port=5432;Database=dbMatcher;User Id=admin;Password=Veverka378378;MaxPoolSize=100;Timeout=15;CommandTimeout=300").Dialect<PostgreSQL83Dialect>());

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
