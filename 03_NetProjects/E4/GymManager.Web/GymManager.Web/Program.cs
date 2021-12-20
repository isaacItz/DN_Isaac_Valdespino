using GymManager.ApplicationServices.Members;
using GymManager.ApplicationServices.Navigation;
using System.Globalization;
using Serilog;

CultureInfo culture;
culture = CultureInfo.CreateSpecificCulture("ex-MX");
Thread.CurrentThread.CurrentUICulture = culture;
Thread.CurrentThread.CurrentCulture = culture;
CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;
var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog((hostingContext, loggerConfiguration) =>
{
    loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration);
});
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddTransient<IMembersAppService, MembersAppService>();
builder.Services.AddTransient<IMenuAppService, MenuAppService>();
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Attendance}/{action=Index}/{id?}");
app.UseStaticFiles();

app.Run();