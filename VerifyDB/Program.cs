using Microsoft.EntityFrameworkCore;
using VerifyDB.Data;
using VerifyDB.Extensions;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddAutoMapper(c => c.AddProfile<MapperProfile>());

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<DataContext>(optionsBuilder => optionsBuilder.UseSqlServer(builder.Configuration.GetConnectionString(nameof(DataContext))));

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapHealthChecks("/health");
    endpoints.MapControllers();
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
