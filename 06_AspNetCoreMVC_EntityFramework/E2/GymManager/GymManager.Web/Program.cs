using Microsoft.AspNetCore.Identity;
using GymManager.ApplicationServices.Members;
using GymManager.ApplicationServices.Navigation;
using GymManager.DataAccess.Repositories;
using GymManager.Core.Members;
using System.Globalization;
using Serilog;
using GymManager.DataAccess;
using Microsoft.EntityFrameworkCore;

CultureInfo culture;
culture = CultureInfo.CreateSpecificCulture("ex-MX");
Thread.CurrentThread.CurrentUICulture = culture;
Thread.CurrentThread.CurrentCulture = culture;
CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<GymManagerContext>(options => 
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
);
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
    options.SignIn.RequireConfirmedAccount = true
).AddEntityFrameworkStores<GymManagerContext>();
builder.Host.UseSerilog((hostingContext, loggerConfiguration) =>
{
    loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration);
});
builder.Services.ConfigureApplicationCookie(options =>
    options.LoginPath = "/Account/LogIn"
);
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddTransient<IMembersAppService, MembersAppService>();
builder.Services.AddTransient<IMenuAppService, MenuAppService>();
builder.Services.AddTransient<IRepository<int, Member>, Repository<int, Member>>();
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Attendance}/{action=Index}/{id?}");
app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();

app.Run();