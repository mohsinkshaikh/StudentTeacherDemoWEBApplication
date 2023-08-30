using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StudentTeacherDemoWEBApplication.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<StudCourseDBContext>(Options =>
{
    Options.UseSqlServer(builder.Configuration.GetConnectionString("NewConnection"));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
