using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApplication3.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//setup cors
builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", Options => Options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

//DbContext
var severVersion = new MySqlServerVersion(new Version(8, 0, 31));

builder.Services.AddDbContext<DataDbContext>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("Default"), severVersion);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//cors
app.UseCors(
    options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
    );

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
