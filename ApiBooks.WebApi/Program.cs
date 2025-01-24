using ApiBooks.BusinessLayer.Abstract;
using ApiBooks.BusinessLayer.Concrete;
using ApiBooks.DataAccessLayer.Abstract;
using ApiBooks.DataAccessLayer.Context;
using ApiBooks.DataAccessLayer.EntityFramework;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApiContext>();

builder.Services.AddScoped<ICategoryService,CategoryManager>();
builder.Services.AddScoped<ICategoryDal,EfCategoryDal>();

builder.Services.AddScoped<IBookService,BookManager>();
builder.Services.AddScoped<IBookDal,EfBookDal>();

builder.Services.AddScoped<IFeatureService,FeatureManager>();
builder.Services.AddScoped<IFeatureDal,EfFeatureDal>();

builder.Services.AddScoped<IWriterService,WriterManager>();
builder.Services.AddScoped<IWriterDal,EfWriterDal>();

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
