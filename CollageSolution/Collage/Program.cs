using Collage.EfCoreContext.ConnectionSetting;
using Collage.EfCoreContext.EfRepository;
using Collage.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

//Server Side
var connectionString = builder.Configuration.GetConnectionString("CollagSolution");
builder.Services.AddDbContext<DBSContext>(connection => connection.UseSqlServer(connectionString));

//Interface scopes
builder.Services.AddScoped<IAddressSettingRepository, EfAddressSettingRepository>();
builder.Services.AddScoped<IPrecenceAbsecenceRepository, EfPrecenceAbsecenceRepository>();

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
    endpoints.MapControllerRoute("HomePage", "{controller=Home}/{action=Main}/");
});

app.Run();
