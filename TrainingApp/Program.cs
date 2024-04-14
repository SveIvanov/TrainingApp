using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TrainingApp.Core.Contracts;
using TrainingApp.Core.Services;
using TrainingApp.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<TrainingDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddScoped<IHiitServices, HiitServices>();

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireDigit = false;
    options.Password.RequiredUniqueChars = 0;
    })
    .AddEntityFrameworkStores<TrainingDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
