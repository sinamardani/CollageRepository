
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

//Server Side
var connectionString =  builder.Configuration.GetConnectionString("CollagSolution");


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("Home/Error");
    app.UseHsts();
}


app.UseStaticFiles();
app.UseStatusCodePages();

//Root setting
app.UseRouting();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("HomePage", "/{controller = Home}/{action = Main}/");
});

app.Run();
