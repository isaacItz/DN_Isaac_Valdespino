using GymManager.ApplicationServices.Members;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddTransient<IMembersAppService, MembersAppService>();
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Attendance}/{action=Index}/{id?}");
app.UseStaticFiles();

app.Run();