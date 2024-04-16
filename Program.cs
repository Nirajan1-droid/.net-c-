using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
string consStr = builder.Configuration.GetConnectionString("myConStr");
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<YourDbContext>(options => options.UseSqlServer(consStr));

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
app.MapControllerRoute(
           name: "Student",
           pattern: "Students/{action=Index}",
           defaults: new { controller = "Student" });

app.Run();
