var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();


app.UseStaticFiles();

app.MapControllerRoute(
    pattern: "{controller=home}/{action=index}/{id?}",
    name: "default"
    );
app.Run();

