using GymManager.ApplicationServices.Members;
using System.Globalization;
CultureInfo culture;
culture = CultureInfo.CreateSpecificCulture("ex-MX");
Thread.CurrentThread.CurrentUICulture = culture;
Thread.CurrentThread.CurrentCulture = culture;
CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddTransient<IMembersAppService, MembersAppService>();
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Attendance}/{action=Index}/{id?}");
app.UseStaticFiles();

app.Run();