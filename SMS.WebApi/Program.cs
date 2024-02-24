using Microsoft.EntityFrameworkCore;
using SMS.WebApi;
using SMS.WebApi.DataBaseContext;
using SMS.WebApi.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IStudentRepository , StudentRepository>();
builder.Services.AddDbContext<ApplicationDB>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Conn")));
builder.Services.AddAutoMapper(typeof(ICore).Assembly);
// Add services to the container.

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
