var builder = WebApplication.CreateBuilder(args);

// Add services to the container
//register database or anything like that is done here by adding services to services.newservice()

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline. starts from now: 
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//rules:route error page->route staticFiles ->useRouting for middleware->routing for authorization ->routing for authentication
app.UseHttpsRedirection();
//middleware to use the static files
app.UseStaticFiles();
//this is the routing middleware
app.UseRouting();
//this is the auth middleware
app.UseAuthorization();//after the authorization the authentication come into play. so write the authentication logic after the authorization.
//based on the routing this  MapControllerRoute will map the request to the controller files.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
