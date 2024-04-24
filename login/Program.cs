using login.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.WithOrigins("*")
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<AplicattionDbcontext>(opciones
   => opciones.UseSqlServer("name=DefaultConnection"));

builder.Services.AddIdentityApiEndpoints<IdentityUser>()
    .AddEntityFrameworkStores<AplicattionDbcontext>();

builder.Services.AddAuthorization();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapGroup("/identity").MapIdentityApi<IdentityUser>();
app.UseHttpsRedirection();

app.UseCors("AllowAll");
app.UseAuthorization();
app.MapControllers();

app.Run();
