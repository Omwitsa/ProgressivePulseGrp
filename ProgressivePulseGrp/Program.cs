using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using ProgressivePulseGrp.Models;
using ProgressivePulseGrp.Utilities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("MySqlDatabase");
// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<HatuaGrpDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDbContext<HatuaGrpDbContext>(option => option.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

//builder.Services.AddTransient<IEmailProvider, EmailProvider>();
builder.Services.AddNotyf(config =>
{
    config.DurationInSeconds = 10;
    config.IsDismissable = true;
    config.Position = NotyfPosition.TopCenter;
});

//builder.Services.AddSession(options => {
//    options.IdleTimeout = TimeSpan.FromHours(1);//You can set Time   
//});

//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
//        .AddCookie(options =>
//        {
//            options.LoginPath = "/account/login";
//            options.SlidingExpiration = true;
//            options.AccessDeniedPath = "/account/denied";
//            //options.Cookie.Name = ".AspNetCore.Cookies";
//            //options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
//        });

//// Add services to the container.
//builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

//app.UseSession();
app.UseRouting();

app.UseAuthorization();

//app.UseAuthorization();

app.UseNotyf();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

Utility.UpdateDatabase(app);
app.Run();