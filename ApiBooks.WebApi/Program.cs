using ApiBooks.BusinessLayer.Abstract;
using ApiBooks.BusinessLayer.Concrete;
using ApiBooks.BusinessLayer.Container;
using ApiBooks.DataAccessLayer.Abstract;
using ApiBooks.DataAccessLayer.Context;
using ApiBooks.DataAccessLayer.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApiContext>();

builder.Services.ContainerDependencies();

builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
    options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
