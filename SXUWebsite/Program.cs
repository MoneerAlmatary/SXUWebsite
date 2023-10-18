using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SXUWebsite.Data;
using SXUWebsite.Repositories;
using SXUWebsite.Profiles;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

/*builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
*/builder.Services.AddTransient<IBrokerages, Broker>();
builder.Services.AddTransient<IContact, Contact>();
builder.Services.AddTransient<IListedcom, Listedcom>();
builder.Services.AddTransient<IInvestors, Investor>();
builder.Services.AddTransient<IStocks, StockRep>();
/*builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
*/builder.Services.AddScoped(P => new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new ListedComProfile());


}).CreateMapper());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
