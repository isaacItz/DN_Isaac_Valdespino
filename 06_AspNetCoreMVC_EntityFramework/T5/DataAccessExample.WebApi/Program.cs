using Microsoft.EntityFrameworkCore;
using DataAccessExampleEntityFramework;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("Default");
// Add services to the container.
builder.Services.AddDbContext<VehiclesDataContext>(options => 
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
builder.Services.AddTransient<IQueriesExample, QueriesExample>();
builder.Services.AddTransient<IColorsDataManager, ColorsDataManager>();
builder.Services.AddTransient<IVehiclesDataManager, VehiclesDataManager>();
builder.Services.Configure<ApiBehaviorOptions>(options => 
{
    options.SuppressModelStateInvalidFilter = true;
}
);


builder.Services.AddControllers().AddNewtonsoftJson ( 
 x=> x.SerializerSettings.ReferenceLoopHandling
 = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
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