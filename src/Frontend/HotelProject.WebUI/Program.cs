var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient(); //Controller üzerinde constructor olusturdugumuz icin bu servisi eklemeliyiz.

//Razor sayfalari icin yapilan degisikliklerde programi derlemeden sadece sayfanin yenilenmesi ile degisikliklerin aktif olmasi icin
//ilk önce Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation nuget paketi ilgili katmana kurulur,
//sonra da su iki komut eklenir:
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

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
