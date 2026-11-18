using Microsoft.EntityFrameworkCore;
using Free4u_Mini_App.Data;

try 
{ 
var builder = WebApplication.CreateBuilder(args);

// 1. Đăng ký kết nối SQLite với EF Core
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
}
catch (Exception ex)
{
    Console.WriteLine($"Lỗi khởi động ứng dụng: {ex.Message} - {ex.StackTrace}");
    throw;
}
