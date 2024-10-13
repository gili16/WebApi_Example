using BL;
using OrderDal;

using Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDal<Order>, OrderDal.OrderDal>();
builder.Services.AddScoped<IBL<Order>, OrderBL>();
builder.Services.AddScoped<IDal<Customer>, CustomerDal>();
builder.Services.AddScoped<IBL<Customer>, CustomerBL>();
builder.Services.AddScoped<IDal<Product>, ProductDal>();
builder.Services.AddScoped<IBL<Product>, ProductBL>();
builder.Services.AddSingleton<IContext, Data>();
// Add CORS configuration
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
        builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


// Use CORS middleware
app.UseCors("AllowOrigin");


app.UseAuthorization();

app.MapControllers();

app.Run();
