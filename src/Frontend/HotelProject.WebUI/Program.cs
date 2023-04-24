using HotelProject.DataAccessLayer.Concretes.EntityFramework.Contexts;
using HotelProject.EntityLayer.Concretes.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Önce DbContext eklenir
builder.Services.AddDbContext<MsDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MsSQL"));
});

//Sonra Identity yapisi cagrilir
builder.Services.AddIdentity<AppUser, AppRole>(options =>
{
    options.Password.RequiredLength = 3;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
}).AddEntityFrameworkStores<MsDbContext>();




// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient(); //Controller üzerinde constructor olusturdugumuz icin bu servisi eklemeliyiz.

//Razor sayfalari icin yapilan degisikliklerde programi derlemeden sadece sayfanin yenilenmesi ile degisikliklerin aktif olmasi icin
//ilk önce Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation nuget paketi ilgili katmana kurulur,
//sonra da su iki komut eklenir:
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

builder.Services.AddAutoMapper(typeof(Program)); //AutoMapper servisini tanimliyoruz ve bulundugu Assembly'de bir Class adi (Program.cs) veriyoruz.

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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
