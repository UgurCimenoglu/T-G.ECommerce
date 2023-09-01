using Microsoft.EntityFrameworkCore;
using T_G.ECommerce.Business.ServiceRegistration;
using T_G.ECommerce.DataAccess.Context;
using T_G.ECommerce.DataAccess.ServiceRegistration;
using T_G.ECommerce.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//When project start db will create automatically itself with seed datas through below 2 lines
ECommerceDbContext context = new();
await context.Database.MigrateAsync();

//Service Registration extensions called
builder.Services.AddDataAccessServices();
builder.Services.AddBusinessServices();

//Add cors policy
builder.Services.AddCors(opt =>
{
    opt.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("https://localhost:7091").AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Custom Exception Extension Added
app.ConfigureExceptionHandler<Program>(app.Services.GetRequiredService<ILogger<Program>>());

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
