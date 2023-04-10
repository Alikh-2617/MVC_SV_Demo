using DAL.DataCantext;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//------------------------------------------------------------------------------------------ package tools 
builder.Services.AddDbContext<ApplicationDbContext>(options=>options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefualtConnection")));

//builder.Services.AddSession(options => { options.Cookie.IsEssential = true; });
//builder.Services.AddMemoryCache();
//builder.Services.AddDistributedMemoryCache();
//builder.Services.AddSingleton<ITempDataProvider , CookieTempDataProvider>();

var app = builder.Build();

//-------------------------------------------------------------------------------------------
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//-----------------------------packege entity
//app.UseSession();
//app.UseCookiePolicy();



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
